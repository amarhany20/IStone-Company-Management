   M S B A M L   `   `   `  ����M  IIStone Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:IStone_ApplicationIStone_Application  5   	   /    )IStone_Application.W16_Admin_Payment_Edit   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:IStone_Application     5   	     � Title$  W16_AdminPayment��5   	   $	��700��6"   $
��1200��6/    � 
ResizeMode$ CanMinimize=�6<    � WindowStartupLocation$ CenterScreen=�6U   .��5	      � .+�5
   
   �� -   5         ��Name$ textbox_Search��5
      $
��Left=�6*   $��23��6E   $��	10,10,0,0q�6Q    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��225��6�   �� 5   
   -   5         ��Name$ button_Search��5      $��Search��6(   $
��Left=�69   $��
240,10,0,0q�6T   $	��Top=�6h   $��85��6�   $��23��6�    �� 	IsDefault . 6�   �� 5   
   -   5         ��Name$ checkbox_SearchByDate��5      $"��Search by date like : 9-2020��62   $
��Left=�6Y   $��
330,15,0,0q�6t   $	��Top=�6�   $	��170��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagrid_Payments��5      $
��Left=�6.   $	��582��6I   $��	10,38,0,0q�6V   $	��Top=�6i   $
��1174��6�   	   SelectionMode$	 Single=�6�   
   CanUserAddRows
 .     CanUserDeleteRows .  6�   �� 5   
   -   5        $ button_ApplyChanges��5      $��Apply Changes��6.   $
��Left=�6F   $��
10,625,0,0q�6a   $	��Top=�6u   $	��135��6�   $��36��6�   6�   �� 5   
   -   5        $ button_Delete��5      $��Delete Selected��6(   $
��Left=�6B   $��979,625,0,0q�6]   $	��Top=�6r   $	��125��6�   $��36��6�   6�   �� 5   
   -   5        $ button_back��5      $
��Back��6&   $
��Left=�65   $��1109,641,0,0q�6P   $	��Top=�6f   $��75��6~   6�   5      5      