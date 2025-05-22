using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ClosedXML.Excel;
using CommonUtilities;

namespace CloudBackup {
    public static class SheetUtilities {
        public static void CreateSheet(Usersheet usersheet, string outputPath, string password, string zipPath) {
            using (XLWorkbook workbook = GetWorkbook(usersheet)) {
                string sourcePath = $"{Path.GetDirectoryName(outputPath)}\\{Path.GetFileNameWithoutExtension(outputPath)}.xlsx";
                workbook.SaveAs(sourcePath);

                Zip zip = new Zip() {
                    FileName = zipPath
                };
                ZipOperation operation = new ZipOperation() {
                    Files = new string[] { sourcePath },
                    OutputArchivePath = outputPath,
                    Password = password,
                    Progress = new Progress<float>()
                };

                operation.Execute(zip);

                File.Delete(sourcePath);
            }
        }

        private static XLWorkbook GetWorkbook(Usersheet usersheet) {
            string[][] cells = new string[usersheet.Items.Count + 1][];
            cells[0] = new string[] { "Name", "Path in program", "ID", "Password", "Base64 string password", "Link", "Last updated" };

            for (int i = 0; i < usersheet.Items.Count; i++) {
                var pair = usersheet.Items.ElementAt(i);

                string lastUpdated = "Never";
                DateTime time = pair.Value.LastUpdated;
                if (time > DateTime.MinValue) lastUpdated = time.ToString();

                string password = pair.Value.LastPassword;
                string path = pair.Value.LastPathInProgram;

                cells[i + 1] = new string[] { Path.GetFileName(path), path, pair.Value.Item.GeneratedID, password, Convert.ToBase64String(Encoding.UTF8.GetBytes(password)), pair.Value.LastLink, lastUpdated };
            }

            return CreateWorkbook(cells);
        }
        private static XLWorkbook CreateWorkbook(string[][] cells) {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            for (int y = 0; y < cells.Length; y++) {
                string[] row = cells[y];

                for (int x = 0; x < row.Length; x++) {
                    var cell = worksheet.Cell(y + 1, x + 1);

                    cell.Value = row[x];
                    if (y == 0) {
                        cell.Style.Font.Bold = true;
                    }
                }
            }

            worksheet.Columns().AdjustToContents();

            return workbook;
        }

        private static void GetUpdateableItems(Group group, IList<UpdateableItem> output) {
            foreach (var item in group.Items) {
                if (typeof(UpdateableItem).IsAssignableFrom(item.GetType())) {
                    output.Add(item as UpdateableItem);
                } else if (item.GetType() == typeof(Group)) {
                    GetUpdateableItems(item as Group, output);
                }
            }
        }
    }
}
