   M S B A M L   `   `   `  ����M  IIStone Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:IStone_ApplicationIStone_Application  5   	   -    'IStone_Application.W09_Payment_Creation   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:IStone_Application     5   	     � Title$  Order's Payment         ��5   	   $	��700��5	      $
��1200��6    � 
ResizeMode$ CanMinimize=�6%    � WindowStartupLocation$ CenterScreen=�6>   .��5
      � .+�5   
   �� $��Marble Photo.jpg��6   $
��Fill=�6*   $��
-3,0,-3,-3q�69   �� 5   
   -   5         ��Name$ label_Title��5      $�� ��6%   $
��Left=�60   $��	10,10,0,0q�6K   $	��Top=�6^   $��55��6v   $
��1174��6�   $��Center=�6�   $��18(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagrid_Payments��5      $
��Left=�6.   $	��532��6I   $��	10,70,0,0q�6V   $	��Top=�6i   $
��1174��6�      
IsReadOnly .    SelectionMode$ Single=�6�   �� 5   
   -   5        $ label_PaymentName��5      $��Payment Name:��6+   $
��Left=�6C   $��
10,607,0,0q�6^   $	��Top=�6r   $	��205��6�   �� 5   
   -   5        $ label_Amount��5      $��Amount��6&   $
��Left=�67   $��220,607,0,0q�6R   $	��Top=�6g   $	��200��6   �� 5   
   -   5         ��Name$ textbox_Name��5      $
��Left=�6(   $��23��6C   $��
10,638,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��205��6�   �� 5   
   -   5        $ textbox_Amount��5      $
��Left=�6*   $��23��6E   $��220,638,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��205��6�   	 �� 	MaxLength$	 9��6�   �� 5   
   -   5        
 ��Name$
 button_AddPayment��5      $��Add Payment��6,   $
��Left=�6B   $��430,638,0,0q�6]   $	��Top=�6r   $	��125��6�   $��23��6�   6�   �� 5   
   -   5        $"
 button_DeleteSelectedPayment��5      $��Delete Selected Payment��67   $
��Left=�6Y   $��954,638,0,0q�6t   $	��Top=�6�   $	��150��6�   $��23��6�   6�   �� 5   
   -	   5        $
 button_Back��5      $
��Back��6&   $
��Left=�65   $��1109,638,0,0q�6P   $	��Top=�6f   $��75��6~   $��23��6�   6�   5      5      