   M S B A M L   `   `   `  ����M  IIStone Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:IStone_ApplicationIStone_Application  5   	   ,    &IStone_Application.W19_Admin_User_Edit   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:IStone_Application     5   	     � Title$  W8_AllUsers��5      $	��700��6.   $
��1200��6;    � 
ResizeMode$ CanMinimize=�6H    � WindowStartupLocation$ CenterScreen=�6a   .��5      � .+�5	   
   �� $��Marble Photo.jpg��6   $
��Fill=�6*   $��
-3,0,-3,-3q�69   �� 5
   
   -   5         ��Name$ textbox_Search��5
      $
��Left=�6*   $��31��6E   $��	10,10,0,0q�6Q    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��335��6�   �� 5   
   -   5         ��Name$ button_Search��5      $��Search��6(   $
��Left=�69   $��
350,10,0,0q�6T   $	��Top=�6h   $��95��6�   $��31��6�    �� 	IsDefault . 6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagrid_Users��5      $
��Left=�6+   $	��558��6F   $��	10,48,0,0q�6S   $	��Top=�6f   $
��1174��6~      SelectionMode$ Single=�6�   	   CanUserAddRows	 .  
   CanUserDeleteRows
 .  6�   �� 5   
   -   5         ��Name$ label_Count��5      $�� ��6%   $
��Left=�60   $��1106,10,0,0q�6K   $	��Top=�6`   $��78��6x   $��35��6�   �� 5   
   -   5        $ button_DeleteUser��5      $��Delete User��6,   $
��Left=�6B   $��
10,612,0,0q�6]   $	��Top=�6q   $	��230��6�   $��49��6�   6�   �� 5   
   -   5        $ button_SetAdmin��5      $ ��Set Selected User As Admin��6*   $
��Left=�6O   $��246,612,0,0q�6j   $	��Top=�6   $	��230��6�   $��49��6�   6�   �� 5   
   -   5        $ button_SetWorker��5      $!��Set Selected User As Wroker��6+   $
��Left=�6Q   $��482,612,0,0q�6l   $	��Top=�6�   $	��230��6�   $��49��6�   6�   �� 5   
   -   5        $ button_Back��5      $
��Back��6&   $
��Left=�65   $��1094,634,0,0q�6P   $	��Top=�6f   $��90��6~   $��27��6�   �� 5   
   -	   5        $ button_ApplyChanges��5      $��Apply Changes��6.   $
��Left=�6F   $��717,612,0,0q�6a   $	��Top=�6v   $	��230��6�   $��49��6�   6�   �� 5   
   -
   5         ��Name$" checkbox_SearchByFirstLetter��5      $^��XSearch by customer's first letter. For example "A" will show all the names starting in A��69   $
��Left=�6�   $��
450,25,0,0q�6�   $	��Top=�6�   $	��473��6�   $��20��6�   5      5      