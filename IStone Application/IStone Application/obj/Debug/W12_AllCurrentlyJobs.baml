   M S B A M L   `   `   `  ����M  IIStone Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:IStone_ApplicationIStone_Application  5   	   -    'IStone_Application.W12_AllCurrentlyJobs   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:IStone_Application     5   	     � Title$  W7_CurrentJobs��5   
   $	��700��6!   $
��1200��6.    � 
ResizeMode$ CanMinimize=�6;    � WindowStartupLocation$ CenterScreen=�6T   .��5
      � .+�5   
   �� $��Marble Photo.jpg��6   $
��Fill=�6*   $��
-3,0,-3,-3q�69   �� 5   
   -   5         ��Name$ textbox_Search��5      $
��Left=�6*   $��31��6E   $��	10,10,0,0q�6Q    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��317��6�   �� 5   
   -   5         ��Name$ button_Search��5      $��Search��6(   $
��Left=�69   $��
333,10,0,0q�6T   $	��Top=�6h   $	��126��6�   $��31��6�    �� 	IsDefault . 6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagrid_AllJobs��5      $
��Left=�6-   $	��578��6H   $��	10,47,0,0q�6U   $	��Top=�6h   $
��1174��6�      
IsReadOnly . 	   SelectionMode$	 Single=�6�   �� 5   
   -   5        $
��Back��5      $
��Left=�6    $��1052,631,0,0q�6;   $	��Top=�6Q   $	��132��6i   $��27��6�   �� 5   
   -   5        
 ��Name$
 label_Count��5      $�� ��6%   $
��Left=�60   $��1082,10,0,0q�6K   $	��Top=�6`    J� RenderTransformOrigin$ 1.974,0.385&�6x   $	��102��6�   $��35��6�   �� 5   
   -   5         ��Name$ checkbox_SearchByDate��5      $/��)Search By "Month-Year" like this "9-2020"��62   $
��Left=�6z   $��	472,8,0,0q�6�   $	��Top=�6�   $	��294��6�   $��20��6�   �� 5   
   -   5        $" checkbox_SearchByFirstLetter��5      $^��XSearch by customer's first letter. For example "A" will show all the names starting in A��69   $
��Left=�6�   $��
472,27,0,0q�6�   $	��Top=�6�   $	��473��6�   $��20��6�   5      5      