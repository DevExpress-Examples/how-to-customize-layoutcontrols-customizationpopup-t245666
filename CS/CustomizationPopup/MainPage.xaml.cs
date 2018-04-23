using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DevExpress.Xpf.LayoutControl;
using DevExpress.Xpf.Core;

namespace CustomizationPopup {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }
    }

    public class MyLayoutControl : LayoutControl {
        protected override PanelControllerBase CreateController() {
            return new MyLayoutControlController(this);
        }
    }

    public class MyLayoutControlController : LayoutControlController {
        public MyLayoutControlController(ILayoutControl control) : base(control) { }

        protected override LayoutControlCustomizationController CreateCustomizationController() {
            return new MyLayoutControlCustomizationController(this);
        }
    }

    public class MyLayoutControlCustomizationController : LayoutControlCustomizationController {
        public MyLayoutControlCustomizationController(LayoutControlController controller) : base(controller) { }

        protected override LayoutItemCustomizationToolbar CreateCustomizationToolbar() {
            return new MyLayoutItemCustomizationToolbar();
        }
    }

    public class MyLayoutItemCustomizationToolbar : LayoutItemCustomizationToolbar {
        public override void OnApplyTemplate() {
            base.OnApplyTemplate();
            //HorizontalAlignmentElement.Visibility = Visibility.Collapsed;
            //VerticalAlignmentElement.Visibility = Visibility.Collapsed;
            //SelectParentElement.Visibility = Visibility.Collapsed;
            //ItemMovingUIVisibility = Visibility.Visible;
            //RenameElement.Visibility = Visibility.Collapsed;
            //MoveItemBackwardElement.Visibility = Visibility.Collapsed;
            //MoveItemForwardElement.Visibility = Visibility.Collapsed;
            MoveToAvailableItemsElement.Visibility = Visibility.Collapsed;
        }
    }
}
