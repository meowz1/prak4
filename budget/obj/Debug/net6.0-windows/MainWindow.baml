   M S B A M L   `   `   `  ����A  =budget, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:budgetbudget  5   	       budget.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:budget     5   	   -   5          � Title$  
MainWindow��5	   	   $	��450��6   $	��450��6)   $	��800��69   $	��500��6E   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      $
��0.4* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Table��5      $��1��6"   $��5��6/   $��219,2,10,50q�6j   $��2��6   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ Picker��5      $��0��6%   $��2��63   $��5q�6G   �� 5   
   -   5         ��Name$
 Itog��5      $��8��6   $��0��6+   $��Center=�67   $��5q�6T   �� 5   
   -   5         ��Name$ NameNote��5      $��5��6$   $��
10,7,342,2q�61   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$" Названиt записи��6E   �� 5   
   -   5         ��Name$ TypeNote��5      $��5��6%   $��258,25,93,0q�62   $ Тип записи��6G   $	��Top=�6s   �� 5   
   -   5        	 ��Name$	 AddTypeNote��5      $��6��6&   $��258,10,94,10q�63   $��Добавить тип��6I   ���#8080806u   �� 5    
   -   5        $ SumMoney��5       $��4��6$   $��10,13,342,50q�61   $ Общая сумма��6G   $��2��6t   �� 5!   
   -	   5        $	 AddNote��5!      $��6��6"   $��0,10,352,10q�6/   $#��Добавить запись��6D   ���#8080806s   �� 5"   
   -
   5        $	 
UpdateNote��5"      $��7��6%   $��0,10,352,10q�62   $#��Изменить запись��6G   ���#8080806a   �� 5#   
   -   5        $	 
DeleteNote��5#      $��7��6%   $��260,10,93,10q�62   $!��Удалить запись��6H   ���#8080806v   5$      5%      