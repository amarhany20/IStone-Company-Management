   M S B A M L   `   `   `  ����M  IIStone Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:IStone_ApplicationIStone_Application  5   	   )    #IStone_Application.W10_Order_Status   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:IStone_Application     5   	     � Title$  W6_CurrentJobStatus��5   	   $	��700��6&   $
��1200��63    � 
ResizeMode$ CanMinimize=�6@    � WindowStartupLocation$ CenterScreen=�6Y   .��5	      � .+�5
   
   �� $��Marble Photo.jpg��6   $
��Fill=�6*   $��
-3,0,-3,-3q�69   �� 5   
   -   5         ��Name$ label_Count��5      $�� ��6%   $
��Left=�60   $��
1084,0,0,0q�6K   $	��Top=�6_   $��95��6w   $��35��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagrid_CurrentJobs��5      $
��Left=�61   $	��519��6L   $��	10,34,0,0q�6Y   $	��Top=�6l   $
��1169��6�      
IsReadOnly .    SelectionMode$ Single=�6�   �� 5   
   -   5         ��Name$ button_DrawingDone��5      $��Drawing Done��6-   $
��Left=�6D   $��
10,558,0,0q�6_   $	��Top=�6s   $	��160��6�   $��47��6�   �� 5   
   -   5        $ button_ProgramDone��5      $��Program Done��6-   $
��Left=�6D   $��179,558,0,0q�6_   $	��Top=�6t   $	��159��6�   $��47��6�   �� 5   
   -   5        $ button_CuttingDone��5      $��Cutting Done��6-   $
��Left=�6D   $��348,558,0,0q�6_   $	��Top=�6t   $	��160��6�   $��47��6�   �� 5   
   -   5        $ button_FinishingDone��5      $��Finishing Done��6/   $
��Left=�6H   $��517,558,0,0q�6c   $	��Top=�6x   $	��159��6�   $��47��6�   �� 5   
   -   5        $ button_PolishingDone��5      $��Polishing Done ��6/   $
��Left=�6I   $��685,558,0,0q�6d   $	��Top=�6y   $	��160��6�   $��47��6�   �� 5   
   -   5        $ button_Delivered��5      $��	Delivered��6+   $
��Left=�6?   $��855,558,0,0q�6Z   $	��Top=�6o   $	��159��6�   $��47��6�   �� 5   
   -	   5        $ button_PaymentDone��5      $��Payment Done��6-   $
��Left=�6D   $��1023,558,0,0q�6_   $	��Top=�6u   $	��160��6�   $��47��6�   �� 5   
   -
   5        $ button_EndJob��5      $
��Left=�6(   $��517,612,0,0q�6C   $	��497��6X   $��51��6d   $	��Top=�6p   $��End Job��6�   $��20(�6�   �� 5   
   -   5        $ button_Back��5      $
��Back��6&   $
��Left=�65   $��1023,612,0,0q�6P   $	��Top=�6f   $	��156��6~   $��51��6�   �� 5   
   -   5        $ button_IncomingMarbleList��5      $��Incoming Marble List��64   $
��Left=�6S   $��
10,612,0,0q�6n   $	��Top=�6�   $	��160��6�   $��48��6�   6�   �� 5   
   -   5        $ button_PaymentList��5      $��Payment List��6-   $
��Left=�6D   $��179,612,0,0q�6_   $	��Top=�6t   $	��159��6�   $��48��6�   6�   �� 5   
   -   5        $ button_AddJobs��5      $��Add Jobs��6)   $
��Left=�6<   $��348,612,0,0q�6W   $	��Top=�6l   $	��160��6�   $��48��6�   6�   5      5      