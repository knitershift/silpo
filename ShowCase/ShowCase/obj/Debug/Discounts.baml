   M S B A M L   `   `   `  ����C  ?ShowCase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ShowCaseShowCase  5   	   T PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	       ShowCase.Discounts   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ShowCase     5   	   J FWpfAnimatedGif, Version=1.4.14.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	     � Title$  Знижки��5
   	   $	��350��6   $	��580��6%   $	��580��61   $	��250��6@    � ShowInTaskbar .   � WindowStartupLocation$ CenterOwner=�6f   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridDiscounts��5         
IsReadOnly . ���#CDC673$��2 0 2 2q�6W    � 	Resources 5         CellStyleCenter �� 
TargetType*  $System.Windows.Controls.DataGridCell �� Property �� Value��%V   &	        �� 5      "  60   .�5      ��  � ��$ Center=�6<   5      5      	   ColumnHeaderStyle	 5      �� 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5      ��  � ��$
 Bold"�64   �� 5       � ��$ Stretch=�6<   �� 5       � ��$ Center=�6C   �� 5       � ��$ Segoe UI)�63   �� 5       � ��$ 14(�61   �� 5       � ��$ Normal"�63   �� 5       � �� �#EE9A0063   �� 5       � ��$ 30��6/   �� 5       � ��$ 5,0,5,0q�60   �� 5       � ��
 �����64   �� 5       � ��$ 0 0 1 0q�68   �� 5        � ��
 �   �63   5!      
   Columns
 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Товар��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.40* 6M      
Foreground
 �   �1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *name+6[     5%      $ Відсоток��6%   $ 65 6S   
 �   �   	CellStyle# [  6q    67   �� *	percent+6q     5&      $ Стара ціна��6%   $ 80 6V   
 �   �# [  6t    69   �� *
oldPrice+6t     5'      $ Нова ціна��6%   $ 80 6U   
 �   �# [  6s    68   �� *
newPrice+6s     5(      $ Початок��6%   $ 70 6T   
 �   �# [  6r    66   �� *	startDate+6r     5)      $ Кінець��6%   $ 70 6Q   
 �   �# [  6p    65   �� *	endDate+6p   5+      �� 5,   
   $��Center=�6   $��Center=�6.   .+�5-      �� -   5         ��Name$ 
imgLoading��5-   a   "  WpfAnimatedGif.ImageBehavior   AnimatedSource$ Images/loader.gif��6   $��UniformToFill=�6I    �� BitmapScalingMode$ HighQuality=�6u    �� EdgeMode$ Aliased=�6�   $��GifLoad.gif��6�   $	��130��6�   $��-65 -65 0 0q�6�    J� Opacity$ .8Q�6�   $y�Hidden=�6  5.      5/      50      