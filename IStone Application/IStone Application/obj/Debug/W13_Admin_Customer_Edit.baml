   M S B A M L   `   `   `  ����M  IIStone Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:IStone_ApplicationIStone_Application  5   	   0    *IStone_Application.W13_Admin_Customer_Edit   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:IStone_Application     5   	     � Title$  W9_AllCustomers��5      $	��700��6(   $
��1200��65    � 
ResizeMode$ CanMinimize=�6B    � WindowStartupLocation$ CenterScreen=�6[   .��5	      � .+�5
   
   �� $��Marble Photo.jpg��6   $
��Fill=�6*   $
��-3,0q�69   �� 5   
   -   5         ��Name$ textbox_Search��5      $
��Left=�6*   $��31��6E   $��	12,10,0,0q�6Q    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��245��6�   �� 5   
   -   5         ��Name$ button_Search��5      $��Search��6(   $
��Left=�69   $��
263,10,0,0q�6T   $	��Top=�6h   $��96��6�   $��31��6�    �� 	IsDefault . 6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagrid_Customers��5      $
��Left=�6/   $	��565��6J   $��	12,48,0,0q�6W   $	��Top=�6j   $
��1172��6�      SelectionMode$ Single=�6�   	   CanUserAddRows	 .  
   CanUserDeleteRows
 .  6�   �� 5   
   -   5         ��Name$ label_Count��5      $�� ��6%   $
��Left=�60   $��1106,10,0,0q�6K   $	��Top=�6`   $��78��6x   $��35��6�   �� 5   
   -   5         ��Name$ checkbox_SearchByDate��5      $/��)Search By "Month-Year" like this "9-2020"��62   $
��Left=�6z   $��
364,10,0,0q�6�   $	��Top=�6�   $	��287��6�   $��20��6�   �� 5   
   -   5        $ button_ApplyChanges��5      $��Apply Changes��6.   $
��Left=�6F   $��
10,618,0,0q�6a   $	��Top=�6u   $	��229��6�   $��49��6�   6�   �� 5   
   -   5        $ button_DeleteCustomer��5      $��Delete Selected Customer��60   $
��Left=�6S   $��248,618,0,0q�6n   $	��Top=�6�   $	��229��6�   $��49��6�   6�   �� 5   
   -   5        $ button_SelectUser��5      $9��3Select a username to set to this selected
Customer��6,   $
��Left=�6r   $��483,618,0,0q�6�   $	��Top=�6�   $	��229��6�   $��49��6�   6�   �� 5   
   -	   5        $ button_Back��5      $
��Back��6&   $
��Left=�65   $��1094,632,0,0q�6P   $	��Top=�6f   $��90��6~   $��27��6�   �� 5   
   -
   5        $" checkbox_SearchByFirstLetter��5      $^��XSearch by customer's first letter. For example "A" will show all the names starting in A��69   $
��Left=�6�   $��
364,28,0,0q�6�   $	��Top=�6�   $	��473��6�   $��20��6�   �� 5   
   -   5        $ button_CreateCustomer��5      $��Create Customer��60   $
��Left=�6J   $��717,618,0,0q�6e   $	��Top=�6z   $	��229��6�   $��49��6�   6�   5      5      