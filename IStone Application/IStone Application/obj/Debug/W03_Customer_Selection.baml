   M S B A M L   `   `   `  ����M  IIStone Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:IStone_ApplicationIStone_Application  5   	   /    )IStone_Application.W03_Customer_Selection   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:IStone_Application     5   	     � Title$  Customer Selection��5   	   $	��700��6%   $
��1200��62    � 
ResizeMode$ CanMinimize=�6?    � WindowStartupLocation$ CenterScreen=�6X   .��5	      � .+�5
   
   �� $��Marble Photo.jpg��6   $
��Fill=�6*   $��
-3,0,-3,-3q�69   �� 5   
   -   5         ��Name$ textbox_Search��5      $
��Left=�6*   $��31��6E   $��	10,11,0,0q�6Q    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��341��6�   �� 5   
   -   5         ��Name$ button_Search��5      $��Search��6(   $
��Left=�69   $��
357,11,0,0q�6T   $	��Top=�6h   $	��150��6�   $��31��6�    �� 	IsDefault . 6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagrid_Customers��5      $
��Left=�6/   $	��516��6J   $��	10,76,0,0q�6W   $	��Top=�6j   $
��1174��6�      
IsReadOnly . 	   SelectionMode$	 Single=�6�   
   CanUserDeleteRows
 .  6�   �� 5   
   -   5        $ button_SelectCustomer��5      $��Select Customer��60   $
��Left=�6J   $��
10,599,0,0q�6e   $	��Top=�6y   $	��168��6�   $��61��6�    . 6�   �� 5   
   -   5        $ button_CreateANewCustomer��5      $��Create a new customer��64   $
��Left=�6T   $��184,599,0,0q�6o   $	��Top=�6�   $	��161��6�   $��61��6�   6�   �� 5   
   -   5        $ button_Close��5      $��Close��6'   $
��Left=�67   $��1094,636,0,0q�6R   $	��Top=�6h   $��90��6�   $��27��6�   �� 5   
   -   5         ��Name$ checkbox_SearchByDate��5      $/��)Search By "Month-Year" like this "9-2020"��62   $
��Left=�6z   $��
512,11,0,0q�6�   $	��Top=�6�   $	��294��6�   $��20��6�   �� 5   
   -   5         ��Name$ label_Count��5      $�� ��6%   $
��Left=�60   $��
1094,7,0,0q�6K   $	��Top=�6_   $��90��6w   $��35��6�   �� 5   
   -	   5        $" checkbox_SearchByFirstLetter��5      $^��XSearch by customer's first letter. For example "A" will show all the names starting in A��69   $
��Left=�6�   $��
512,30,0,0q�6�   $	��Top=�6�   $	��473��6�   $��20��6�   5      5      