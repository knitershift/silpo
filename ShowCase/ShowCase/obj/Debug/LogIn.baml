   M S B A M L   `   `   `  ����C  ?ShowCase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ShowCaseShowCase  5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	       ShowCase.LogIn   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ShowCase     5   	   J FWpfAnimatedGif, Version=1.4.14.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5      JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	     � Title$  Сільпо��5
   	   $	��500��6   $	��450��6%    � Icon$ silpoicon.ico��62    � 
ResizeMode$ NoResize=�6G    � WindowStartupLocation$ CenterScreen=�6]   (  "MahApps.Metro.Controls.MetroWindow   IsMinButtonEnabled .      IsMaxRestoreButtonEnabled .     ShowIconOnTitleBar .  .��5      �  � 	Resources 5   
    �� 
TargetType   LoginButton	 �� Property
 �� Value �� 
TargetType �� Triggers P� Property P� Value  	RegButton��%�  &	        &	 �    �� 5      " ��6   .�5      �� 	 �@�Cursor$

 Hand��6+   �� 5      	 � ��
 �#90EE906/   �� 5      	 � ��
 5      �� 5      " ��6*   .R�5      �� 
�������$��0q�6=   #��z��6Q   ._�5   "   �� $��Center=�63   $��Center=�6P   5      5      5       5      P� 5       �@J�IsMouseOver . . �5      �� 	 � ��

 �����67   �� 5      	 � ��
 �#66CD0067   5      5!      �� 5#      " ��6   .�5$      �� 	 � ��
 �#87CEFA6/   �� 5%      	 �@�Cursor$

 Hand��6+   �� 5&      	 � ��
 5'      �� 5(      " ��6*   .R�5)      �� 
�������$��0q�6=   #��z��6Q   ._�5*   "   �� $��Center=�63   $��Center=�6P   5+      5,      5.       50      P� 51       �@J�IsMouseOver . . �52      �� 	 � ��

 �����6;   �� 53      	 � ��
 �#00BFFF67   54      56      57       � RowDefinitions 59   
   �� 5:      $	��150 �6   �� 5;      $
��Auto �6   �� 5<      $
��Auto �6   �� 5=       � ColumnDefinitions 5?   
   �� 5@      �� 5A      .+�5D   
   ]� $��2��6   .+�5E      �� $ ��Вхід у магазин��6   $
��Left=�6-   $��36(�6C   $��Normal"�6Q   $��	35 45 0 0q�6e   �� 5F      $��Images/Logo_Silpo.jpg��6   $��Right=�64   $��Right=�6K    �� BitmapScalingMode$ HighQuality=�6g    �� EdgeMode$ Aliased=�6�   $	��195��6�   5G      �� 5J   
    �� Orientation$ Vertical=�6   $��1��6,   $��2��69   .+�5K      �� -   5         ��Name$ label1��5K      $��Логін:��6$   $��28(�65   $��Light"�6C   $��Center=�6V   �� 5L      -   5         ��Name$ textBox_Login��5L      $��chief��6-   $��24(�6:    �� TextAlignment$ Center=�6H   $
��15 0q�6_   5M      �� 5O   
   $ Vertical=�6   $��2��6,   $��2��69   $
��0 15q�6M   .+�5P      �� -   5        $ label��5P      $��Пароль:��6#   $��28(�65   $��Light"�6C   $��Center=�6V   G� 5Q      -   5         G�Name$ textBox_Password��5Q      $��24(�64    G� Password$ chiefpas��6B   $��Center=�6V   $��
15 0 15 25q�6z   5R      �� 5T   
   -   5         ��Name$ button_LogIn��5T      #��[  6'   $��Увійти��6M   $��25(�6^   $��Light"�6l   $��3��6�   $��0��6�   �� 5U   
   -   5        $ button_Registration��5U      #��[ 6.   $��0q�6Q   $��Реєстрація��6e   $��25(�6z   $��Light"�6�   $��3��6�   $��1��6�   �� 5V   
   $��1��6   $��2��6   $��	120 0 0 0q�62   .+�5W      �� -   5         ��Name$ 
imgLoading��5W   b   "  WpfAnimatedGif.ImageBehavior   AnimatedSource$ Images/loading.gif��6   $��UniformToFill=�6J   $ HighQuality=�6v   $ Aliased=�6�   $��GifLoad.gif��6�   $	��200��6�   $y�Hidden=�6�   5X      5Y      5Z      