   M S B A M L   `   `   `  ����M  IIStone Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:IStone_ApplicationIStone_Application  5   	   #    IStone_Application.W01_SignIn   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:IStone_Application     5   	     � Title$  Sign in and Register��5   	   $	��700��6&   $
��1200��63    � 
ResizeMode$ CanMinimize=�6@    � WindowStartupLocation$ CenterScreen=�6Y   .��5	      � .+�5
   
   �� $��Marble Photo.jpg��6   $
��Fill=�6*   $��
-3,0,-3,-3q�69   �� 5   
   -   5         ��Name$ label_Title��5      $��ISTONE��6%   $��Center=�66   $	��Top=�6S   $
��1194��6k   $��
Wide Latin)�6x   $��40(�6�   $��Center=�6�   $��0,10,0,0q�6�   �� 5   
   -   5        $ label_LoginUsername��5      $��Username : ��6-   $
��Left=�6C   $��
10,155,0,0q�6^   $	��Top=�6r   $��70��6�   �� 5   
   -   5        $ Label_LoginPassword��5      $��Password : ��6-   $
��Left=�6C   $��
10,183,0,0q�6^   $	��Top=�6r   $��70��6�   �� 5   
   -   5         ��Name$ textbox_LoginUsername��5      $
��Left=�61   $��23��6L   $��
85,158,0,0q�6X    �� TextWrapping$
 Wrap=�6l   $	��Top=�6�   $	��329��6�   G� 5   
   -   5         G�Name$ passwordbox_LoginPassword��5      $
��Left=�69   $��
85,186,0,0q�6T   $	��Top=�6h   $	��329��6�   $��23��6�   �� 5   
   -   5         ��Name$ button_Login��5      $��Login��6'   $
��Left=�67   $��169,214,0,0q�6R   $	��Top=�6g   $	��135��6   $��23��6�    �� 	IsDefault . 6�   �� 5   
   -   5        $ label_RegisterUsername��5      $��Username : ��60   $
��Left=�6F   $��740,155,0,0q�6a   $	��Top=�6v   $��70��6�   �� 5   
   -   5        $ label_RegisterPassword��5      $��Password : ��60   $
��Left=�6F   $��740,186,0,0q�6a   $	��Top=�6v   $��70��6�   �� 5   
   -	   5        $" label_RegisterRepeatPassword��5      $��Repeat Password :��66   $
��Left=�6R   $��700,217,0,0q�6m   $	��Top=�6�   $	��110��6�   �� 5   
   -
   5        $ 
label_Rank��5      $��Rank :��6$   $
��Left=�65   $��763,243,0,0q�6P   $	��Top=�6e   $��47��6}   $��24��6�   �� 5   
   -   5        $ textbox_RegisterUsername��5      $
��Left=�64   $��23��6O   $��815,161,0,0q�6[   $
 Wrap=�6p   $	��Top=�6�   $	��359��6�   G� 5   
   -   5        $" passwordbox_RegisterPassword��5      $
��Left=�6<   $��815,189,0,0q�6W   $	��Top=�6l   $	��359��6�   $��23��6�   G� 5   
   -   5        $) #passwordbox_RegisterRepeatePassword��5      $
��Left=�6C   $��815,217,0,0q�6^   $	��Top=�6s   $	��359��6�   $��23��6�   �� 5   
   -   5        	 ��Name$	 combobox_Rank��5      $
��Left=�6*   $��815,245,0,0q�6E   $	��Top=�6Z   $	��359��6r   �� 5   
   -   5        $ button_RegisterButton��5      $��Register��60   $
��Left=�6C   $��934,272,0,0q�6^   $	��Top=�6s   $	��135��6�   $��23��6�   6�   �� 5   
   $	��IP:��6   $
��Left=�6   $��884,606,0,0q�69   $	��Top=�6N   $	��181��6f   �� 5   
   -   5        $ 
textbox_IP��5      $
��Left=�6&   $��23��6A   $��884,637,0,0q�6M   $
 Wrap=�6b   $��192.168.1.16��6v   $	��Top=�6�   $	��181��6�   �� 5   
   -   5        $ 	button_IP��5      $��Set Database IP��6$   $
��Left=�6>   $��1070,637,0,0q�6Y   $	��Top=�6o   $	��114��6�   $��23��6�   6�   5      5      