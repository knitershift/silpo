   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   C ?ShowCase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ShowCaseShowCase 5   	      ShowCase.Registration   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   (localclr-namespace:ShowCase     5   	     � Title$  Реєстрація��5	   	    � Icon$ silpoicon.ico��6   $	��415��61   $	��550��6>    � WindowStartupLocation$ CenterScreen=�6J    � 
ResizeMode$ NoResize=�6o   (   "MahApps.Metro.Controls.MetroWindow   IsMinButtonEnabled .      IsMaxRestoreButtonEnabled .  .��5
      �  � 	Resources 5   
    �� 
TargetType   	RegButton �� Property	 �� Value
 �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5      " ��6   .�5      ��  � ��
	 �����6/   �� 5       � ��	 �#00BFFF6/   �� 5       �@�Cursor$
	 Hand��6+   �� 5       � ��	 5      �� 5      "
 ��6*   .R�5      �� 
����ح�$��1q�6>   #��z��6R   ._�5   "   �� $��Center=�63   $��Center=�6P   5      5      5       5      P� 5       �@J�IsMouseOver . . �5      ��  � ��
	 � ���67   5      5       5!       � RowDefinitions 5#   
   �� 5$      $
��Auto �6   �� 5%      $
��Auto �6   �� 5&      $
��Auto �6   �� 5'      $
��Auto �6    � ColumnDefinitions 5*   
   �� 5+      $��* �6   �� 5,      $��* �6   .+�5.   
   ��  �� Orientation$ Vertical=�6   $��2��6,   $��0 0 0 15q�6@   .+�5/      �� $��Images/membership.png��6   $	��150��63    �� BitmapScalingMode$ HighQuality=�6@    �� EdgeMode$ Aliased=�6n   �� 50      $%��Новий користувач��6   $��26(�6/   $��Center=�6=   51      �� 53   
   $ 
Horizontal=�6   $��1��6.   $��0��6;   $��Right=�6K   $��	0 0 25 20q�6g   .+�54      �� $��ПІБ:��6   $��18(�6#   �� 55      -   5         ��Name$ textBox_FullName��55      $��18(�60   $	��180��6>   56      �� 58   
   $ 
Horizontal=�6   $��2��6.   $��0��6;   $��Right=�6K   $��0 0 25 0q�6g   .+�59      �� $��Місто:��6   $��18(�6%   �� 5:      -   5        $ textBox_City��5:      $��18(�6,   $	��180��6:   5;      �� 5>   
   $ 
Horizontal=�6   $��1��6.   $��1��6;   $��Right=�6K   $��	0 0 20 20q�6g   .+�5?      �� $��Логін:��6   $��18(�6%   �� 5@      -   5        $ textBox_Login��5@      $��18(�6-   $	��180��6;   5A      �� 5C   
   $ 
Horizontal=�6   $��2��6.   $��1��6;   $��Right=�6K   $��0 0 20 0q�6g   .+�5D      �� $��Пароль:��6   $��18(�6&   �� 5E      -   5        $ textBox_Password��5E      $��18(�60   $	��180��6>   5F      �� 5H   
   -   5         ��Name$ 	button_OK��5H      $��Реєструвати��6$   $��25(�6:   $��Light"�6H   $	��250��6[   $��50��6g   $��3��6s   $��2��6�   $
��0 25q�6�   #��[  6�   5I      5J      