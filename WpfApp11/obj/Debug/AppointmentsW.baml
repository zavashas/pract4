   M S B A M L   `   `   `  ����C  ?WpfApp11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp11WpfApp11  5   	       WpfApp11.AppointmentsW   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp11     5   	     � Title$  Приемы��5   	   $	��450��6   $	��900��6%   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ AppointmentsViewGrd��5         AutoGenerateColumns .  $��0��6M   $��0��6]   $��4��6j      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО пациента��6%      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *PatientFullName+6_     5      $ ФИО врача��6%    .  68   �� *DoctorFullName+6[     5      $ Дата приема��6%    .   6:   �� *DateAppointment+	 �� StringFormat$	 {0:dd/MM/yyyy HH:mm}��6�     5      $ Описание��6%    .   67   �� *DescriptionAppointment+6b   5      �� 5    
   -   5        
 ��Name$
 SearchTextBox��5       $��1��6)   $��0��69   $��32��6F   $	��348��6R   $
��Left=�6^   $	��Top=�6y   .��6�   ��5!      �� 5"       �� 
TargetType" ��6   .�5#      ��  �� Property � �� �� Value
 �   �63   �� 5$       � �� 5%      �� 5&       �� 
TargetType" ��6.   .R�5'   "   � .+�5(   &   ��  ��Name$ PART_ContentHost��63   �� 5)   &    ��Name$ Placeholder��60   $B��<Введите фамилию и инициалы врача��6E   
�������$y�	Collapsed=�5*   :   5+   #    �� Triggers 5,   "   ]� 5-   &    ]� 
Conditions 5.   *   �� 5/   .    �� Property �@J�	IsFocused �� Value .  6M   �� 50   .    � ��$  ��6H   ./�52   *   ��  �� 
TargetName$ Placeholder��61    � y�$ Visible=�6`   53   '   55      57      58      .��59      5:      �� 5<   
   -   5        $��
Поиск��5<      $��1��66   $��0��6F   $	��100��6S   ���	#FF9DBA9F$��Right=�6v   $	��Top=�6�   �� 5=   
   -   5        $��Очистка��5=      $��1��67   $��1��6G   $	��100��6T   ���	#FF9DBA9F$��Right=�6w   $	��Top=�6�   �� 5>   
   -   5         ��Name$ 	DoctorCbx��5>       �� DisplayMemberPath$ DoctorFullName��6&   $��1��6w   $	��348��6�   $
��Left=�6�   6�   �� 5?   
   -   5        $��
Назад��5?      $��2��6!   $��3��61   $	��100��6R   $��Right=�6^   $��Bottom=�6z   ���	#FF9DBA9F6�   5@      5A      