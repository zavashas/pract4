   M S B A M L   `   `   `  ����C  ?WpfApp11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp11WpfApp11  5   	       WpfApp11.DoctorsW   5   	   _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp11     5   	     � Title$  
Врачи��5	   	   $	��450��6   $	��800��6$   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DoctorsViewGrd��5         AutoGenerateColumns .  $��0��6G   $��4��6T      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *DoctorSurname+  5      $ Имя��6%    62   �� *
DoctorName+  5      $ Отчество��6%    67   �� *DoctorMiddleName+  5      $  Специализация��6%    6<   �� *SpecializationName+5      �� 5   
   -   5        $��
Назад��5      $	��100��65   $��Right=�6A   $��Bottom=�6]   ���	#FF9DBA9F$��1��6�   $��3��6�   �� 5    
   -   5         ��Name$ SearchTextBox��5       $��1��6)   $��0��69   $��32��6F   $	��300��6R   $
��Left=�6^   $	��Top=�6y   .��6�   ��5!      �� 5"      	 �� 
TargetType"	 ��6   .�5#      �� 
 �� Property
 � �� �� Value
 �   �63   �� 5$      
 � �� 5%      �� 5&       �� 
TargetType" ��6.   .R�5'   "   � .+�5(   &   ��  ��Name$ PART_ContentHost��63   �� 5)   &    ��Name$ Placeholder��60   $:��4Введите специализацию врача��6E   
�������$y�	Collapsed=�5*   2   5+   #    �� Triggers 5,   "   ]� 5-   &    ]� 
Conditions 5.   *   �� 5/   .    �� Property �@J�	IsFocused �� Value .  6M   �� 50   .    � ��$  ��6H   ./�52   *   ��  �� 
TargetName$ Placeholder��61   
 � y�$ Visible=�6`   53   '   55      57      58      .��59      5:      �� 5;   
   -   5        $��
Поиск��5;      $��1��66   $��0��6F   $	��100��6S   ���	#FF9DBA9F$��Right=�6v   $	��Top=�6�   �� 5<   
   -   5        $��Очистка��5<      $��1��67   $��1��6G   $	��100��6T   ���	#FF9DBA9F$��Right=�6w   $	��Top=�6�   �� 5=   
   -   5         ��Name$ 
DoctorsCbx��5=       �� DisplayMemberPath$ SpecializationName��6'   $��1��6}   $	��300��6�   $
��Left=�6�   6�   5?      5@      