   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5   	   U QCaliburn.Micro, Version=1.5.2.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21fG4clr-namespace:Caliburn.Micro;assembly=Caliburn.MicroCaliburn.Micro 5   	    Caliburn.Micro.SimpleMDI(   "Caliburn.Micro.SimpleMDI.ShellView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   (calhttp://www.caliburnproject.org  5   	   XiPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity  5   	   =ca4clr-namespace:Caliburn.Micro;assembly=Caliburn.Micro  5   	   $	��640��5   	   $	��480��5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
       � WindowState$ 	Maximized=�5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   $��87��6,    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5      �� -   5         ��Name$ Search��5      $��2��6&   $��0��66   $��3q�6C   $��25��6N   .��6Z   .   (System.Windows.Interactivity.Interaction   Triggers 5   
   /   )System.Windows.Interactivity.EventTrigger  5         	EventName$ KeyUp��6!   .   (System.Windows.Interactivity.TriggerBase   Actions. 5      "  Caliburn.Micro.ActionMessage  	   
MethodName$	 NameLostFocus��6#   
   
Parameters.
 5         Caliburn.Micro.Parameter     Value 6'   ��  �� ElementName$ Search�� �� Path$
 Text�6X   5!      5"      .��5#   "   5$      �� 5&   
   -   5        $	��Add��5&      $��0��6   $��0��6-   $��Right=�6:   $��0,3,3,3q�5'       � ToolTip$ Add Contact��6    .��5(      ��  �� Orientation$ 
Horizontal=�6   .+�5)      �� $��icons\Actions.png��6   $��35��6/   $��40��6;   $��Uniform=�6F   5+      5,      &   System.Windows.Controls.DataGrid  5-   
   -   5        $
��List��5-      $��1��6    $	��Top=�6-      
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6W   $��3��6g      AutoGenerateColumns .    RowStyle 5/   
   �� 50       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�51      �� 	  Caliburn.Micro.Message �� Property �@	 Attach �� Value$; 5[MouseDoubleClick] = [Action RowSelect($dataContext)]��67   52      54      56      57      