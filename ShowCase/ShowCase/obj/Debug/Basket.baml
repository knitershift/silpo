   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5      C ?ShowCase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ShowCaseShowCase 5   	      ShowCase.Basket   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      (localclr-namespace:ShowCase     5   	     � Title$  Корзина��5	   	   $��431.955��6   $��820.797��6*    � Icon$ silpoicon.ico��6:   $	��800��6O   $	��400��6^    � WindowStartupLocation$ CenterOwner=�6n   (   "MahApps.Metro.Controls.MetroWindow   ShowIconOnTitleBar .  .��5
      � .+�5   
   �� $0��*Товари у вашій корзині:��6   $��14(�62   $��15q�6@   �� 5   
   $��Кількість:��6   $��14(�6%   $��	0 15 30 0q�63   $��Right=�6F   �� 5   
   -   5         ��Name$ labelAmount��5      $��0��6   $��14(�61   $��15q�6?   $��Right=�6K   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid_basket��5      $��	0,49,0,64q�6,   $
��Left=�6?   $	��811��6Z      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$	 №��67   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6B   �� *number+  5       . $ 
Назва��67   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 170 6_   	 6F   �� *name+6_     5       . $ Ціна��67   $
 90 6_   	 6E   �� *price+6_     5       . $ Виробник��67   $	
 150 6f   	 6I   �� *
producer+6f     5       . $ Країна��67   $	
 100 6c   	 6G   �� *	country+6c     5       .  $ Кількість��68   $
 80 6t   	 6L   �� *amount+ �� Mode$ TwoWay=�   	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6    .�5      ��  �� Property � {� �� Value .  6:    �� Triggers 5      �� 5   "    �� Binding 6F   ��  �� Path$ Column.Header� �� RelativeSource �� *Self+ �� Value PART_IsSelected6.   .a�5   &   ��  � {� . 6B   5   #   5      5!        5"       . $ Сума��67   $
 70 6^   	 6E   �� *suma+6^     5#       . $ Видалити��67   $
 90 6_   	 6I   �� *b+6_   5%      �� 5&   
   -   5         ��Name$ buttonClear��5&      $%��Очистити корзину��6&   $
��Left=�6[   $��
47,343,0,0q�6v   $	��Top=�6�   $	��129��6�   $��37��6�   �� 5'   
   -   5        $ buttonToBuy��5'      $��Купити��6&   $
��Left=�6Q   $��620,343,0,0q�6l   $	��Top=�6�   $	��152��6�   $��37��6�   5)      5*      