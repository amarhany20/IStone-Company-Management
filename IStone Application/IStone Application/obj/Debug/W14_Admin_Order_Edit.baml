   M S B A M L   `   `   `  ����M  IIStone Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:IStone_ApplicationIStone_Application  5   	   -    'IStone_Application.W14_Admin_Order_Edit   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:IStone_Application     5   	     � Title$  W10_AllOrders��5   	   $	��700��6   $
��1200��6,    � 
ResizeMode$ CanMinimize=�69    � WindowStartupLocation$ CenterScreen=�6R   .��5	      � .+�5
   
   �� $��Marble Photo.jpg��6   $
��Fill=�6*   $��
-3,0,-3,-3q�69   �� 5   
   -   5         ��Name$ textbox_Search��5      $
��Left=�6*   $��31��6E   $��	10,10,0,0q�6Q    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��246��6�   �� 5   
   -   5         ��Name$ button_Search��5      $��Search��6(   $
��Left=�69   $��
262,10,0,0q�6T   $	��Top=�6h   $��95��6�   $��31��6�   6�   �� 5   
   -   5         ��Name$ label_Count��5      $�� ��6%   $
��Left=�60   $��1106,10,0,0q�6K   $	��Top=�6`   $��78��6x   $��35��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagrid_Orders��5      $
��Left=�6,   $	��572��6G   $��	10,50,0,0q�6T   $	��Top=�6g   $
��1174��6      SelectionMode$ Single=�6�   	   CanUserAddRows	 .  6�   �� 5   
   -   5        $ button_ApplyChanges��5      $*��$Apply Changes and Refresh All Tables��6.   $
��Left=�6]   $��
10,629,0,0q�6x   $	��Top=�6�   $	��270��6�   $��27��6�   �� 5   
   -   5        $ button_Back��5      $
��Back��6&   $
��Left=�65   $��1094,629,0,0q�6P   $	��Top=�6f   $��90��6~   $��27��6�   �� 5   
   -   5        
 ��Name$
 checkbox_SearchByDate��5      $/��)Search By "Month-Year" like this "9-2020"��62   $
��Left=�6z   $��
362,10,0,0q�6�   $	��Top=�6�   $	��288��6�   $��20��6�   �� 5   
   -   5        $ button_DeleteOrder��5      $��Delete Order��6-   $
��Left=�6D   $��950,629,0,0q�6_   $	��Top=�6t   $	��138��6�   $��27��6�   �� 5   
   -	   5        $ button_SelectUser��5      $7��1Select a username to set to this selected
 Order��6,   $
��Left=�6p   $��482,627,0,0q�6�   $	��Top=�6�   $	��229��6�   $��34��6�   6�   �� 5   
   -
   5        $ button_SelectCustomer��5      $5��/Select a Customer to set to this selected
Order��60   $
��Left=�6n   $��716,627,0,0q�6�   $	��Top=�6�   $	��229��6�   $��34��6�   6�   �� 5   
   -   5        $"
 checkbox_SearchByFirstLetter��5      $^��XSearch by customer's first letter. For example "A" will show all the names starting in A��69   $
��Left=�6�   $��
362,29,0,0q�6�   $	��Top=�6�   $	��473��6�   $��20��6�   5      5      