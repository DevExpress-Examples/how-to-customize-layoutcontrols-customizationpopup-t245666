Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.LayoutControl
Imports DevExpress.Xpf.Core

Namespace CustomizationPopup
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class

	Public Class MyLayoutControl
		Inherits LayoutControl
		Protected Overrides Function CreateController() As PanelControllerBase
			Return New MyLayoutControlController(Me)
		End Function
	End Class

	Public Class MyLayoutControlController
		Inherits LayoutControlController
		Public Sub New(ByVal control As ILayoutControl)
			MyBase.New(control)
		End Sub

		Protected Overrides Function CreateCustomizationController() As LayoutControlCustomizationController
			Return New MyLayoutControlCustomizationController(Me)
		End Function
	End Class

	Public Class MyLayoutControlCustomizationController
		Inherits LayoutControlCustomizationController
		Public Sub New(ByVal controller As LayoutControlController)
			MyBase.New(controller)
		End Sub

		Protected Overrides Function CreateCustomizationToolbar() As LayoutItemCustomizationToolbar
			Return New MyLayoutItemCustomizationToolbar()
		End Function
	End Class

	Public Class MyLayoutItemCustomizationToolbar
		Inherits LayoutItemCustomizationToolbar
		Public Overrides Sub OnApplyTemplate()
			MyBase.OnApplyTemplate()
			'HorizontalAlignmentElement.Visibility = Visibility.Collapsed;
			'VerticalAlignmentElement.Visibility = Visibility.Collapsed;
			'SelectParentElement.Visibility = Visibility.Collapsed;
			'ItemMovingUIVisibility = Visibility.Visible;
			'RenameElement.Visibility = Visibility.Collapsed;
			'MoveItemBackwardElement.Visibility = Visibility.Collapsed;
			'MoveItemForwardElement.Visibility = Visibility.Collapsed;
			MoveToAvailableItemsElement.Visibility = Visibility.Collapsed
		End Sub
	End Class
End Namespace
