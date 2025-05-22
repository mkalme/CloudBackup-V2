using System;
using System.Collections.Generic;
using CustomDialogs;

namespace CloudBackup.Gui {
    public static class ItemSelectorUtilities {
        public static InputResult<IList<object>> ShowSelector(Group group, ItemSelectorProfile profile, Func<object, bool> viewableItemValidator) {
            ViewController viewController = new ViewController(new GroupViewNode(group));
            ItemSelectionDataGridViewControl gridViewControl = new ItemSelectionDataGridViewControl(viewableItemValidator) {
                ViewController = viewController
            };

            InputResult<IList<object>> result = CustomDialog.ShowItemSelector(viewController, gridViewControl, profile);
            viewController.Dispose();

            return result;
        }
    }
}
