   M S B A M L   `   `   `  ����M  IIStone Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:IStone_ApplicationIStone_Application  5   	   ,    &IStone_Application.W04_Order_Selection   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:IStone_Application     5   	     � Title$  Current Orders��5   	   $	��700��6!   $
��1200��6.    � 
ResizeMode$ CanMinimize=�6;    � WindowStartupLocation$ CenterScreen=�6T   .��5	      � .+�5
   
   �� $��Marble Photo.jpg��6   $
��Fill=�6*   $��
-3,0,-3,-3q�69   �� 5   
   -   5         ��Name$ label_Title��5      $0��*Choose the order to check the jobs inside.��6%   $
��Left=�6Z   $��
136,10,0,0q�6u   $	��Top=�6�   $	��947��6�   $��54��6�   $��20(�6�   $��Center=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagrid_Orders��5      $
��Left=�6,   $	��536��6G   $��	10,64,0,0q�6T   $	��Top=�6g   $
��1175��6      
IsReadOnly .    SelectionMode$ Single=�6�   �� 5   
   -   5        $ label_Count��5      $�� ��6%   $
��Left=�60   $��1089,36,0,0q�6K   $	��Top=�6`    J� RenderTransformOrigin$ 0.132,0&�6x   $��96��6�   $��35��6�   �� 5   
   -   5         ��Name$ button_SelectOrder��5      $��Select Order��6-   $
��Left=�6D   $��
10,607,0,0q�6_   $	��Top=�6s   $	��144��6�   $��54��6�   	 �� 	IsDefault	 . 6�   �� 5   
   -   5        $ button_Back��5      $
��Back��6&   $
��Left=�65   $��1095,634,0,0q�6P   $	��Top=�6f   $��90��6~   $��27��6�   �� 5   
   -   5        $ button_EndOrder��5      $��	End Order��6*   $
��Left=�6>   $��945,607,0,0q�6Y   $	��Top=�6n   $	��144��6�   $��54��6�   6�   5      5      