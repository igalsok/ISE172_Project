   M S B A M L   `   `   `  ����E  AProjectMS2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ProjectMS2.PresentationLayerProjectMS2.PresentationLayer  5   	   1    +ProjectMS2.PresentationLayer.RegisterWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:ProjectMS2.PresentationLayer     5   	   H DMahApps.Metro, Version=1.6.0.0, Culture=neutral, PublicKeyToken=null6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	     � WindowStartupLocation$  CenterScreen=�5	   
    � Title$ RegisterWindow��5
   	   $	��450��6    $	��350��6-   ��5      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ Black��6    � Offset$ 0Q�6)   � 5      $ 	#FFA88BCA��6   $ 1Q�6-   5      .��5      � .+�5   
   �� 
�����F�6   �� 5   
   -   5         ��Name$ lbl_register��5      $��Registeration��6&   $��30(�6>   $
��Left=�6L   $	��Top=�6g   $��63��6   $	��183��6�   $��	59,10,0,0q�6�   �� 5   
   -   5         ��Name$ txtBox_usernameReg��5      $
��Left=�6/   $��23��6J    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��160��6�   $��123,119,0,0q�6�   �� 5   
   -   5        $ lbl_userNameReg��5      $��20(�6)   $��	Username:��67   $
��Left=�6K   $	��Top=�6f   	 J� RenderTransformOrigin$	 3.117,4.179&�6~   $��	0,111,0,0q�6�   �� 5   
   $��Password��6   $��20(�6#   $
��Left=�61   $	��Top=�6L   $��	5,150,0,0q�6d   $��36��6w   $	��108��6�   G� 5   
   -   5        
 G�Name$
 pwd_box��5      $
��Left=�6(   $��123,155,0,0q�6C   $	��Top=�6X   $��23��6p   $	��160��6|   �� 5   
   -   5        $ 
lbl_gIDReg��5      $��groupID:��6$   $��20(�67   $
��Left=�6E   $	��Top=�6`   $��
10,186,0,0q�6x   $��40��6�   $��94��6�   �� 5   
   -   5        $ txtBox_gIDReg��5      $
��Left=�6+   $��23��6F   $
 Wrap=�6R   $	��Top=�6g   $	��160��6   $��123,194,0,0q�6�   �� 5   
   -   5         ��Name$ btn_register��5      $��Register��6'   $
��Left=�6:   $	��Top=�6U   $	��110��6m   $��123,263,0,0q�6y   $��43��6�   6�   �� 5   
   -   5        $ btn_exit��5      $
��Exit��6#   $
��Left=�62   $	��Top=�6M   $��75��6e   $	 0.969,10.056&�6p   $��
10,391,0,0q�6�   6�   5      5      