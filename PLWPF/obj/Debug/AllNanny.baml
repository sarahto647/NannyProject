   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	       PLWPF.AllNanny   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	   +BEclr-namespace:BE;assembly=BE     5   	   -   5          � Title$  Nanny options��5	   	   $��732.475��6   $��716.8��60    � 	Resources 5
         nannyViewSource��%   &	        �� 5   
   6   5      .��5      �   MyBackround#��[ 6   .+�5   
   �� $��Right=�6   
������ $	��700��6J   $��0,0,9,0q�6V   .@�5      �� $	��Add��6   .��5      � $��
0,0,-7.6,0q�6   $	��782��6+   $	��Top=�68    � ColumnDefinitions 5      �� 5      $��* �6+   �� 5      $��* �6+   .+�5      � -   5         �Name$ Addgrid1��5      $��2,0,0,0q�6-   $
��Left=�6>   $	��680��6Y   $��2��6e   $	��772��6y   $	��Top=�6�    � RowDefinitions 5      �� 5      $	��39* �6,   �� 5      $	��37* �6,   �� 5      $	��36* �6,   �� 5      $	��37* �6,   �� 5      $	��37* �6,   �� 5      $	��39* �6,   �� 5      $	��38* �6,   �� 5      $	��38* �6,   �� 5       $	��36* �6,   �� 5!      $	��38* �6,   �� 5"      $	��38* �6,   �� 5#      $	��38* �6,   �� 5$      $	��37* �6,   �� 5%      $	��36* �6,   �� 5&      $	��38* �6,   �� 5'      $	��36* �6,   �� 5(      $	��38* �6,   �� 5)      $	��38* �6,   �� 5*      $	��38* �6,   �� 5+      $	��38* �6,    5-      �� 5.      $
��Auto �6/   �� 5/      $
��Auto �6/   �� 50      $	��19* �6/   �� 51      $
��364* �6/   .+�53      �� $��Center=�6    $��9��6;   $��114,6.6,0,6.6q�6H   $
��Left=�6_   $��0��6z   $��Payment Through Cash?��6�   $��26��6�   $	��147��6�   $��2��6�   �� 54      -   5         ��Name$ cashCheckBox��54   #   $��Center=�69   $��9��6T   $��113.8,13.6,0,10.6q�6a   $
��Left=�6�   $��1��6�   $�� ��6	  $��15��6  $��20��6    d� 	IsChecked 6|   �� *Cash+ �� Mode$ TwoWay=� �� NotifyOnValidationError . 	 �� ValidatesOnExceptions	 . 6   �� 55      $��Center=�6    $��5��6;   $��3,6,0,8q�6H   $
��Left=�6Y   $��0��6t   $��	*Address:��6�   $��26��6�   $��77��6�   �� 56      -   5        
 ��Name$
 addressTextBox��56   "   $	��140��6:   $��Center=�6F   $��5��6�   $��3.8,7.4,0,8q�6�   $��23��6�   $
��Left=�6�   $��1��6
  ��6a   �� *	Address+$ TwoWay=� . 	 . 6
  �� 57      $��Center=�6    $��3��6;   $��	3,5,0,5.8q�6H   $
��Left=�6[   $��0��6v   $��Date Birth:��6�   $��26��6�   $��66��6�   (  "System.Windows.Controls.DatePicker  58      -   5          Name$ dateBirthDatePicker��58   %   $��Center=�6B   $��3��6�   $��3.8,7,0,5.8q�6�   $
��Left=�6�   $��1��6  $��24��6  $	��140��6      SelectedDate 6]   �� *	DateBirth+$ TwoWay=� . 	 . 6   �� 59      $��Bottom=�6    $��3��6;   $��3.6,0,0,5.8q�6H   $
��Left=�6]   $��3��6x   $��Drinks Alcool:��6�   $��26��6�   $��82��6�   �� 5:      -   5        $ drinksAlcoolCheckBox��5:   #   $��Center=�6A   $��3��6\   $��163.6,5,0,9.8q�6i   $
��Left=�6�   $�� ��6  $��22��6  $��20��6   J� RenderTransformOrigin$ -1.65,0.286&�6'  $��3��6K   6�   �� *DrinksAlcool+$ TwoWay=� . 	 . 6K  �� 5;      $��Center=�6    $��6��6;   $��151,6.8,0,6.4q�6H   $
��Left=�6_   $��	Elevator:��6z   $��26��6�   $��60��6�   $ 
3.2,-0.346&�6�   $��2��6�   �� 5<      -   5        $ elevatorCheckBox��5<   #   $��Center=�6=   $��6��6X   $��64.8,13.8,0,10.4q�6e   $
��Left=�6�   $��1��6   $�� ��6  $��15��6  $��20��6'  $ 0.35,-0.067&�62   6   �� *
Elevator+$ TwoWay=� . 	 . 62  �� 5=      $��Center=�6    $��14��6;   $��0.6,6.8,0,6.4q�6I   $
��Left=�6`   $��1��6{   $��Experience With In Needs:��6�   $��26��6�   $	��148��6�   $��2��6�   �� 5>      -   5        $# experienceWithInNeedsCheckBox��5>   #   $��Center=�6J   $��14��6e   $��6.6,12.8,0,10.4q�6s   $
��Left=�6�   $��2��6  $�� ��6*  $��16��65  $��20��6A  $��2��6L   6�   �� *ExperienceWithInNeeds+$ TwoWay=� . 	 . 6L  �� 5?      $��Center=�6    $��6��6;   $��0,2.8,0,10.4q�6H   $
��Left=�6^   $��0��6y   $��Floor:��6�   $��26��6�   $��40��6�   �� 5@      -	   5        $
 floorTextBox��5@   "   $��71��68   $��Center=�6C   $��6��6�   $��48,2.8,0,14.4q�6�   $��22��6�   $
��Left=�6�   ��6^   �� *Floor+$ TwoWay=� . 	 . 6�   �� 5A      $��Center=�6    $��4��6;   $��3,6.2,0,4.6q�6H   $
��Left=�6]   $��0��6x   $��Gender:��6�   $��26��6�   $��77��6�   �� 5B      -
   5         ��Name$ genderNanComboBox��5B   #   $��Stretch=�6>   $��4��6}   $��3.8,6.2,0.2,6.6q�6�   $��Stretch=�6�   $��1��6�    �� SelectedItem 6Z   �� *	GenderNan+6�   �� 5C      $��Center=�6    $��5��6;   $��18.8,5.8,0,8.2q�6H   $
��Left=�6`   $��2��6{   $��Do You Have A Car?��6�   $��26��6�   $	��120��6�   $��2��6�   �� 5D      -   5        $ hasCarCheckBox��5D   #   $��Center=�6;   $��5��6V   $��127.6,9.8,0,14.2q�6c   $
��Left=�6�   $��3��6�   $�� ��6  $��16��6  $��20��6#   6}   �� *HasCar+$ TwoWay=� . 	 . 6#  �� 5E      $��Bottom=�6    $��9��6;   $��	0,0,0,6.6q�6H   $
��Left=�6[   $��0��6v   $��Tariff Hour :��6�   $��26��6�   $��68��6�   �� 5F      -   5        $ hourTariffCheckBox��5F   #   $��Center=�6?   $��9��6Z   $��78,14.6,0,9.6q�6g   $
��Left=�6�   $�� ��6  $��15��6  $��20��6   6~   �� *
HourTariff+$ TwoWay=� . 	 . 6  �� 5G      $��Center=�6    $��3,6,0,8q�6;   $
��Left=�6L   $��0��6g   $
��*Id:��6w   $��26��6�   $��37��6�   �� 5H      -   5        $
 	idTextBox��5H   "   $��Stretch=�65   $��3.8,7,4.2,8.4q�6�   $��Stretch=�6�   $��1��6�   ��6Q   �� *Id+$ TwoWay=� . 	 . 6�   �� 5I      $��Center=�6    $��2��6;   $��3,6,0,6q�6H   $
��Left=�6Y   $��0��6t   $��*Last Name:��6�   $��26��6�   $��77��6�   �� 5J      -   5        $
 lastNameTextBox��5J   "   $��Stretch=�6;   $��2��6�   $��3.8,6.8,4.2,7q�6�   $��Stretch=�6�   $��1��6�   ��6W   �� *
LastName+$ TwoWay=� . 	 . 6�   �� 5K      $��Center=�6    $��13��6;   $��151,8.6,0,2.2q�6I   $
��Left=�6`   $��Maximum:��6{   $��26��6�   $��79��6�   $��2��6�      PLWPF.UserC1  5L      -   5          Name$ userCmax��5L   '      MaxValue$ 12X�6:      MinValue$ 0X�6H   $��Center=�6U   $��65.8,11.6,0.2,4.2q�6r   $��13��6�   $��Center=�6�   $��1��6�   �� 5M      $��Center=�6    $��11��6;   $��
5,3.2,0,10q�6I   $
��Left=�6]   $��
*Max Kids:��6x   $��26��6�   $��60��6�   �� 5N      -   5        $
 maxKidsTextBox��5N   "   $��33��6:   $��Center=�6E   $��11��6�   $��70,4.2,0,11q�6�   $��24��6�   $
��Left=�6�   ��6`   �� *	MaxKids+$ TwoWay=� . 	 . 6�   �� 5O      $��Center=�6    $��13��6;   $��2,9.6,0,1.2q�6I   $
��Left=�6^   $��0��6y   $��Minimum:��6�   $��26��6�   $��67��6�   �� 5P      $��Center=�6    $��1��6;   $��3,6,0,6q�6H   $
��Left=�6Y   $��0��6t   $��*Name:��6�   $��26��6�   $��56��6�   �� 5Q      -   5        $
 nameTextBox��5Q   "   $��Stretch=�67   $��1��6�   $��3.8,7.6,4.2,3.2q�6�   $��Stretch=�6�   $��1��6�   ��6S   �� *Name+$ TwoWay=� . 	 . 6�   �� 5R      $��Center=�6    $��10��6;   $��0,3.4,0,9.8q�6I   $
��Left=�6^   $��0��6y   $��	Per Hour:��6�   $��26��6�   $��59��6�   �� 5S      -   5        $
 perHourTextBox��5S   "   $��36��6:   $��Center=�6E   $��10��6�   $��78,5.4,0,10.8q�6�   $��23��6�   $
��Left=�6�   ��6`   �� *	PerHour+$ TwoWay=� . 	 . 6�   �� 5T      $��Center=�6    $��10��6;   $��3.8,5.4,0,7.8q�6I   $
��Left=�6`   $��1��6{   $��
Per Month:��6�   $��26��6�   $��68��6�   �� 5U      -   5        $
 perMonthTextBox��5U   "   $��41��6;   $��Center=�6F   $��10��6�   $��76.8,9.4,0,6.8q�6�   $��23��6�   $
��Left=�6�   $��1��6  ��6a   �� *
PerMonth+$ TwoWay=� . 	 . 6  �� 5V      $��Center=�6    $��7��6;   $��1,5.6,0,7.6q�6H   $
��Left=�6]   $��0��6x   $��Phone:��6�   $��26��6�   $��46��6�   �� 5W      -   5        $
 phoneTextBox��5W   "   $	��140��68   $��Center=�6D   $��7��6�   $��0.8,8.6,0,7.6q�6�   $��23��6�   $
��Left=�6�   $��1��6  ��6_   �� *Phone+$ TwoWay=� . 	 . 6  �� 5X      $	��Top=�6    $��	3.6,5,0,0q�68   $
��Left=�6K   $��3��6f   $��Religion Nanny:��6v   $��26��6�   $��93��6�   �� 5Y      -   5        $ religionNComboBox��5Y   #   $	��120��6>   $��Bottom=�6J   $��	164,0,0,7q�6�   $��22��6�   $
��Left=�6�   $��3��6�    6e   �� *	ReligionN+6�   �� 5Z      $��Center=�6    $��2��6;   $��3.6,5.8,0,5q�6H   $
��Left=�6]   $��3��6x   $��Smokes:��6�   $��26��6�   $��54��6�   �� 5[      $��Center=�6    $��1��6;   $��3.6,5.6,0,5.2q�6H   $
��Left=�6_   $��3��6z   $��	Languages��6�   $��26��6�   $��67��6�   �� 5\      -   5        $ LanguagesComboBox��5\   #   $��Center=�6>   $��1��6Y   $��163.6,9.6,0,5.2q�6f   $
��Left=�6�   $��3��6�   $	��120��6�   $��22��6�    6   �� *LanguageNanny+6�   �� 5]      $��Center=�6    $��14��6;   $��3,9.8,0,4.4q�6I   $��0��6^   $��Years Of Experience:��6n   $��25��6�   $
��Left=�6�   $	��116��6�   �� 5^      -   5        $
 yearOfExperienceTextBox��5^   "   $��32��6C   $��Center=�6N   $��14��6�   $��119,9.8,0,6.4q�6�   $��23��6�   $
��Left=�6  $��2��6  ��6i   �� *YearOfExperience+$ TwoWay=� . 	 . 6  �� 5_      $��Child Age Range:��6    $��Center=�6;   $
��Left=�6]   $��-4,0,0,0q�6x   $��12��6�   $	��Top=�6�   $��38��6�   $	��145��6�   �� 5`      $��Email:��6    $
��Left=�61   $��Center=�6L   $ 0.019,0.344&�6g   $��0��6�   $��8��6�   $��5,7.4,0,5.4q�6�   $��24��6�   $��42��6�   �� 5a      -   5        $
 emailTextBox��5a   "   $
��Left=�68   $��22��6S   $��Center=�6�   $	��140��6�   $��1��6�   $��8��6�   $��3.8,10.4,0,4.4q�6  ��6_   �� *Email+$ TwoWay=� . 	 . 6  �� 5b      -   5        $ SundayCheckBox��5b   #   $��3��6;   $��7��6K   $��Sunday��6X   $
��Left=�6i   $��	10,13,0,0q�6�   $	��Top=�6�   $��10(�6  $��16��6$  $��53��60   6�   �� *	Worked[0]+$ TwoWay=� . 	 . 60  �� 5c      -   5        $ MondayCheckBox��5c   #   $��3��6;   $��7��6K   $��Monday��6X   $
��Left=�6i   $��	87,13,0,0q�6�   $	��Top=�6�   $��10(�6�   $��16��6$  $��56��60   6�   �� *	Worked[1]+$ TwoWay=� . 	 . 60  �� 5d      -   5        $ TuesdayCheckBox��5d   #   $��3��6<   $��7��6L   $��Tuesday��6Y   $
��Left=�6k   $��
164,13,0,0q�6�   $	��Top=�6�   $��10(�6�   $��16��6'  $��56��63   6�   �� *	Worked[2]+$ TwoWay=� . 	 . 63  �� 5e      -   5        $ WednesdayCheckBox��5e   #   $��3��6>   $��8��6N   $��	Wednesday��6[   $
��Left=�6o   $��	10,10,0,0q�6�   $	��Top=�6�   $��10(�6�   $��15��6+  $��72��67   6�   �� *	Worked[3]+$ TwoWay=� . 	 . 67  �� 5f      -   5        $ ThursdayCheckBox��5f   #   $��3��6=   $��8��6M   $��Thursday��6Z   $
��Left=�6m   $��	87,10,0,0q�6�   $	��Top=�6�   $��10(�6�   $��15��6(  $��60��64   6�   �� *	Worked[4]+$ TwoWay=� . 	 . 64  �� 5g      -   5        $ FridayCheckBox��5g   #   $��3��6;   $��8��6K   $��Friday��6X   $
��Left=�6i   $	��Top=�6�   $��
164,10,0,0q�6�   $��10(�6�   $��15��6&  $��46��62   6�   �� *	Worked[5]+$ TwoWay=� . 	 . 62  �� 5h      -   5        $ SaturdayCheckBox��5h   #   $��3��6=   $��8��6M   $��Saturday��6Z   $
��Left=�6m   $	��Top=�6�   $��	235,8,0,0q�6�   $��10(�6�   $��65��6(  $��15��63   6�   �� *	Worked[6]+$ TwoWay=� . 	 . 6?  � 5i      $
��Left=�6   $��70��6:   $��2.6,13.8,0,0q�6F   $	��Top=�6\   $	��330��6t   $��3��6�   $��9��6�   $��3��6�    5j      �� 5k   "   $��* �60   �� 5l   "   $��* �60   �� 5m   "   $��* �60    5o      �� 5p   "   $��* �63   �� 5q   "   $��* �63   �� 5r   "   $��* �63   �� 5s   "   $��* �63   �� 5t   "   $��* �63   �� 5u   "   $��* �63   �� 5v   "   $��* �63   �� 5w   "   $��* �63   .+�5z      �� $	��Sun��6$   $��1��62   $��Center=�6B   $��Bottom=�6`   $��10(�6{   $��	8,0,8,0.2q�6�   �� 5{      $	��Mon��6$   $��2��62   $��Center=�6B   $��Center=�6_   $��10(�6z   �� 5|      $
��Tues��6$   $��3��63   $��Center=�6C   $��Center=�6a   $��10(�6|   �� 5}      $
��Wedn��6$   $��4��63   $��Center=�6C   $��Center=�6`   $��10(�6{   �� 5~      $��Thurs��6$   $��5��64   $��Center=�6D   $��Center=�6a   $��10(�6|   �� 5      $	��Fri��6$   $��6��62   $��Center=�6B   $��Center=�6`   $��10(�6{   �� 5�      $	��Sat��6$   $��7��62   $��Center=�6B   $��Center=�6`   $��10(�6{   �� 5�      $��Begin��6$   $��Center=�64   $��1��6R   $��Center=�6_   $��10(�6z   �� 5�      $	��End��6$   $��Center=�62   $��2��6P   $��Center=�6]   $��10(�6x   �� 5�      -    5        $ SundayComboBoxBegin��5�   '   $��1��6D   $��Stretch=�6T   $��Bottom=�6r   $��24��6  $��	0,0,0,0.2q�6  $��2��6%  {�6�   ��  �� ElementName$ SundayCheckBox�� �� Path$ 	IsChecked�6%  �� 5�      -!   5        $ MondayComboBoxBegin��5�   '   $��2��6D   $��Stretch=�6T   $��1��6r   $��Stretch=�6   {�6�   �� $ MondayCheckBox��$ 	IsChecked��� 5�      -"   5        $ TuesdayComboBoxBegin��5�   '   $��3��6E   $��Stretch=�6U   $��1��6s   $��Stretch=�6�   {�6�   �� $ TuesdayCheckBox��$ 	IsChecked��� 5�      -#   5        $ WednesdayComboBoxBegin��5�   '   $��4��6G   $��Stretch=�6W   $��1��6u   $��Stretch=�6�   {�6�   �� $ WednesdayCheckBox��$ 	IsChecked��� 5�      -$   5        $ ThursdayComboBoxBegin��5�   '   $��5��6F   $��Stretch=�6V   $��1��6t   $��Stretch=�6�   {�6�   �� $ ThursdayCheckBox��$ 	IsChecked��� 5�      -%   5        $ FridayComboBoxBegin��5�   '   $��6��6D   $��Stretch=�6T   $��1��6s   $��Stretch=�6�   {�6�   �� $ FridayCheckBox��$ 	IsChecked��� 5�      -&   5        $ SaturdayComboBoxBegin��5�   '   $��7��6F   $��Stretch=�6V   $��1��6t   $��Stretch=�6�   {�6�   �� $ SaturdayCheckBox��$ 	IsChecked��� 5�      -'   5        $ SundayComboBoxEnd��5�   '   $��1��6B   $��Stretch=�6R   $��2��6p   $��Stretch=�6}   {�6�   �� $ SundayCheckBox��$ 	IsChecked��� 5�      -(   5        $ MondayComboBoxEnd��5�   '   $��2��6B   $��Stretch=�6R   $��2��6q   $��Stretch=�6~   {�6�   �� $ MondayCheckBox��$ 	IsChecked��� 5�      -)   5        $ TuesdayComboBoxEnd��5�   '   $��3��6C   $��Stretch=�6S   $��2��6q   $��Stretch=�6~   {�6�   �� $ TuesdayCheckBox��$ 	IsChecked��� 5�      -*   5        $ WednesdayComboBoxEnd��5�   '   $��4��6E   $��Stretch=�6U   $��2��6s   $��Stretch=�6�   {�6�   �� $ WednesdayCheckBox��$ 	IsChecked��� 5�      -+   5        $ ThursdayComboBoxEnd��5�   '   $��5��6D   $��Stretch=�6T   $��2��6r   $��Stretch=�6   {�6�   �� $ ThursdayCheckBox��$ 	IsChecked��� 5�      -,   5        $ FridayComboBoxEnd��5�   '   $��6��6B   $��Stretch=�6R   $��2��6p   $��Stretch=�6}   {�6�   �� $ FridayCheckBox��$ 	IsChecked��� 5�      --   5        $ SaturdayComboBoxEnd��5�   '   $��7��6D   $��Stretch=�6T   $��2��6r   $��Stretch=�6   {�6�   �� $ SaturdayCheckBox��$ 	IsChecked�5�      �� 5�      $��*Available Work Days:��6    $��2��6@   $
��Left=�6P   $��18.8,2.8,0,0q�6k   $	��Top=�6�   $	��125��6�   $��6��6�   $��26��6�   $��2��6�   �� 5�      -.   5        $
 recommendationsTextBox��5�   "   $	��219��6B   $��Center=�6N   $��113.4,0,0,0.2q�6�   $	��151��6�   $
��Left=�6�   $��3��6  $��12��6   $��4��6.  ��6i   �� *Recommendations+$ TwoWay=� . 	 . 6.  �� 5�      $��Center=�6    $��3.6,6.2,0,4.6q�6;   $
��Left=�6R   $��3��6m   $&�� Vacation Days Through The TAMAT?��6}   $��26��6�   $	��201��6�   $��4��6�   �� 5�      -/   5        $ smokesCheckBox��5�   #   $��Center=�6;   $��163.6,10.8,0,5q�6V   $
��Left=�6�   $��3��6�   $�� ��6�   $��21��6  $��20��6  $ 3,-1.533&�6  $��2��6@   6n   �� *Smokes+$ TwoWay=� . 	 . 6@  �� 5�      -0   5        $ vacDaysCheckBox��5�   #   $��Center=�6<   $��234.6,14.2,0,7.6q�6W   $
��Left=�6�   $��3��6�   $�� ��6  $��15��6  $��20��6  $ 
0.76,1.827&�6#  $��4��6F   6q   �� *	VacDays+$ TwoWay=� . 	 . 6F  �� 5�      $��Center=�6    $��6.6,35.2,0,16.4q�6;   $
��Left=�6T   $��2��6o   $��Recommendations:��6   $��26��6�   $	��111��6�   $��11��6�   $��2��6�   $��2��6�     5�      -1   5        $ userCmin��5�   '   $ 12X�69   $ 0X�6G   $��Center=�6T   $��63,11.6,10.2,4.2q�6q   $��13��6�   $��Center=�6�   5�      �� 5�      -2   5        $	��Add��5�      $	��Add��6(   $
��Left=�66   $��216,624,0,0q�6Q   $	��Top=�6f   $��90��6~   $��20(�6�   $��1��6�   $ 
0.448,0.49&�6�   $��30��6�   ��5�      �� 5�       �� Triggers 5�   "   �� 5�   &    �� Binding 62   �� $ nameTextBox��$
 Text� �� Value  6i   .a�5�   *   ��  �� Property � {� �� Value .  6M   5�   '   �� 5�   &    62   �� $ 	idTextBox��$
 Text�  6g   .a�5�   *   ��  � {� .  6M   5�   '   �� 5�   &    62   �� $ lastNameTextBox��$
 Text�  6m   .a�5�   *   ��  � {� .  6M   5�   '   �� 5�   &    62   �� $ addressTextBox��$
 Text�  6l   .a�5�   *   ��  � {� .  6M   5�   '   5�      5�      � 5�      -3   5        $ grid2��5�      $��1��6*   $
��Left=�6:   $��142.2,404,0,0q�6U   $	��Top=�6l    5�      �� 5�      $
��Auto �6/   �� 5�      $
��Auto �6/    5�      �� 5�      $
��Auto �6,   5�      5�      5�      �� 5�      $��Update��6   .��5�      � $
��Left=�6   $��	0,0,0,0.4q�62   $	��674��6E    5�      �� 5�      $��* �6+   �� 5�      $��* �6+   .+�5�      �� -4   5        $��Update��5�      $��Update��6+   $
��Left=�6<   $��247.2,613,-0.4,0q�6W   $	��Top=�6q   $��90��6�   $��20(�6�   $��1��6�   $��30��6�   ��5�      �� 5�       5�   "   �� 5�   &    62   �� $ nameTextBox1��$
 Text�  6j   .a�5�   *   ��  � {� .  6M   5�   '   �� 5�   &    62   �� $ lastNameTextBox1��$
 Text�  6n   .a�5�   *   ��  � {� .  6M   5�   '   �� 5�   &    62   �� $ addressTextBox1��$
 Text�  6m   .a�5�   *   ��  � {� .  6M   5�   '   5�      5�      � 5�      -5   5        $ grid4��5�      $��2��6*   $��
0,0,-0.4,0q�6>   $	��720��6R   $	��Top=�6_    5�      �� 5�      $
��Auto �6/   �� 5�      $��160.8 �6/   �� 5�      $��162.4 �6/    5�      �� 5�      $	��34* �6,   �� 5�      $	��35* �6,   �� 5�      $	��34* �6,   �� 5�      $	��34* �6,   �� 5�      $	��35* �6,   �� 5�      $	��34* �6,   �� 5�      $	��34* �6,   �� 5�      $	��35* �6,   �� 5�      $	��34* �6,   �� 5�      $	��35* �6,   �� 5�      $	��34* �6,   �� 5�      $	��34* �6,   �� 5�      $	��34* �6,   �� 5�      $	��34* �6,   �� 5�      $	��35* �6,   �� 5�      $	��35* �6,   �� 5�      $	��34* �6,   �� 5�      $	��34* �6,   �� 5�      $	��33* �6,   �� 5�      $	��34* �6,   �� 5�      $	��35* �6,   .+�5�      �� $��Payment through Cash?��6    $��0��6@   $
��Left=�6P   $��118,4.6,0,6.6q�6k   $��9��6�   $��Center=�6�   $��24��6�   $	��136��6�   $��2��6�   �� 5�      $��Child Age Range:��6    $��0��6;   $
��Left=�6K   $��-1,5.4,0,2.2q�6f   $��12��6|   $��Center=�6�   $��26��6�   $	��101��6�   �� 5�      -6   5        $ cashCheckBox1��5�   #   $�� ��6:   $��1��6E   $
��Left=�6U   $��116.8,8.6,0,11.6q�6�   $��9��6�   $��Center=�6�   $��15��6  $��20��6    6p   �� *Cash+$ TwoWay=� . 	 . 6   �� 5�      $��	*Address:��6    $��0��64   $
��Left=�6D   $��3,5,0,5q�6_   $��5��6p   $��Center=�6}   $��24��6�   $��66��6�   �� 5�      -7   5        $
 addressTextBox1��5�   "   $��1��6;   $
��Left=�6K   $��23��6f   $��2.8,5.2,0,4.6q�6r   $��5��6�   $��Center=�6�   $	��120��6  ��6�   �� *	Address+$ TwoWay=� . 	 . 6  �� 5�      $��Date Birth:��6    $��0��66   $
��Left=�6F   $��3,2.8,0,3.2q�6a   $��3��6v   $��Center=�6�   $��26��6�   $��66��6�     5�      -8   5        $ dateBirthDatePicker1��5�   %   $��1��6C   $
��Left=�6S   $��2.8,3.8,0,4.2q�6n   $��3��6�   $��Center=�6�   $��24��6  $	��102��6#   6�   �� *	DateBirth+$ TwoWay=� . 	 . 6#  �� 5�      $��	Elevator:��6    $��1��64   $
��Left=�6D   $��3.8,4.8,0,2.8q�6_   $��6��6v   $��Center=�6�   $��26��6�   $��54��6�   �� 5      -9   5        $ elevatorCheckBox1��5   #   $�� ��6>   $��1��6I   $
��Left=�6Y   $��65.8,13.8,0,2.8q�6�   $��6��6�   $��Center=�6   $��17��6  $��22��6'   6t   �� *
Elevator+$ TwoWay=� . 	 . 6'  �� 5     $��Email:��6    $��0��61   $
��Left=�6A   $��
-1,8,0,0.4q�6\   $��8��6p   $��Center=�6}   $��26��6�   $��42��6�   �� 5     -:   5        $
 emailTextBox1��5  "   $��1��69   $
��Left=�6I   $��23��6d   $��2.8,8,0,3.4q�6p   $��8��6�   $��Center=�6�   $	��120��6  ��6�   �� *Email+$ TwoWay=� . 	 . 6  �� 5     $��Experience With In Needs:��6    $
��Left=�6D   $��	0,1,0,8.2q�6_   $��15��6r   $��Center=�6�   $��26��6�   $	��147��6�   �� 5     -;   5        $$ experienceWithInNeedsCheckBox1��5  #   $�� ��6K   $��1��6V   $
��Left=�6f   $��9.8,10,0,11.2q�6�   $��15��6  $��Center=�6  $��14��64  $��20��6@   6�   �� *ExperienceWithInNeeds+$ TwoWay=� . 	 . 6@  �� 5     $��Floor:��6    $��0��61   $
��Left=�6A   $��0,4.8,0,2.8q�6\   $��6��6q   $��Center=�6~   $��26��6�   $��40��6�   �� 5     -<   5        $
 floorTextBox1��5  "   $
��Left=�69   $��23��6T   $��45,9.8,0,0.8q�6`   $��6��6v   $��Center=�6�   $��75��6�   ��6�   �� *Floor+$ TwoWay=� . 	 . 6�   �� 5     $��Gender Nan:��6    $��0��66   $
��Left=�6F   $��3,3.8,0,3.8q�6a   $��4��6v   $��Center=�6�   $��26��6�   $��77��6�   �� 5     -=   5        $ genderNanComboBox1��5  #   $��1��6?   $
��Left=�6O   $��22��6j   $��2.8,5.8,0,5.8q�6�   $��4��6�   $��Center=�6�   $	��120��6�    6v   �� *	GenderNan+6�   �� 5
     $��Do You Have A Car?��6    $��2��6=   $
��Left=�6M   $��2,6,0,2q�6h   $��5��6y   $��Center=�6�   $��26��6�   $	��115��6�   �� 5     ->   5        $ hasCarCheckBox1��5  #   $�� ��6<   $��2��6G   $
��Left=�6W   $��
122,0,0,10q�6�   $��5��6�   $��Bottom=�6�   $��14��6  $��20��6   6r   �� *HasCar+$ TwoWay=� . 	 . 6  �� 5     $��Tariff Hour:��6    $��0��67   $
��Left=�6G   $��0,2.6,0,6.6q�6b   $��9��6w   $��Center=�6�   $��26��6�   $��69��6�   �� 5     -?   5        $ hourTariffCheckBox1��5  #   $�� ��6@   $
��Left=�6K   $��87,9.6,0,11.6q�6�   $��9��6�   $��Center=�6�   $��14��6  $��20��6   6f   �� *
HourTariff+$ TwoWay=� . 	 . 6  �� 5     $��*Nanny To Update:��6    $��0��6<   $
��Left=�6L   $��3,5,0,5q�6g   $��Center=�6x   $��24��6�   $	��117��6�   �� 5     -@   5        $ 
idComboBox��5  #   $��1��67   $
��Left=�6H   $��23��6c   $��2.8,5,0,4.8q�6�   $��Center=�6�   $	��120��6�    6o   �� *Id+6�   �� 5     $��
Languages:��6    $��2��65   $
��Left=�6E   $��0.2,5.6,0,0.6q�6`   $��1��6w   $��Center=�6�   $��29��6�   $��69��6�   �� 5     -A   5        $ languageNannyComboBox��5  #   $��2��6B   $
��Left=�6R   $��28��6m   $��118.2,6.6,-88,0.6q�6�   $��1��6�   $��Center=�6�   $	��133��6�    6y   �� *	GenderNan+6�   �� 5     $��*Last Name:��6    $��0��66   $
��Left=�6F   $��3,4,0,4q�6a   $��2��6r   $��Center=�6   $��26��6�   $��77��6�   �� 5     -B   5        $
 lastNameTextBox1��5  "   $��1��6<   $
��Left=�6L   $��23��6g   $��2.8,4.6,0,5.2q�6s   $��2��6�   $��Center=�6�   $	��120��6  ��6�   �� *
LastName+$ TwoWay=� . 	 . 6  �� 5     $��Maximum:��6    $��1��63   $
��Left=�6C   $��2.8,2.8,0,4.8q�6^   $��13��6u   $��Center=�6�   $��26��6�   $��65��6�     5     -C   5        $ 	userCmax1��5  '   $ 12X�6<   $ 0X�6J   $��Center=�6W   $��72.8,5.8,10.8,6.8q�6t   $��13��6�   $��center=�6�   $��1��6�   �� 5     $��
*Max Kids:��6    $
��Left=�65   $��-1,2,0,8q�6P   $��11��6b   $��Center=�6p   $��24��6�   $��70��6�   �� 5     -D   5        $
 maxKidsTextBox1��5  "   $
��Left=�6;   $��23��6V   $��
78,3,0,7.6q�6b   $��11��6v   $��Center=�6�   $��29��6�   ��6�   �� *	MaxKids+$ TwoWay=� . 	 . 6�   �� 5     $��Minimum:��6    $��0��63   $
��Left=�6C   $��3,2.8,0,4.8q�6^   $��13��6s   $��Center=�6�   $��26��6�   $��64��6�     5     -E   5        $ 	userCmin1��5  '   $ 12X�6:   $ 0X�6H   $��Center=�6U   $��67,5.8,6.2,6.8q�6r   $��13��6�   $��center=�6�   �� 5     $��*Name:��6    $��0��61   $
��Left=�6A   $��3,6,0,5q�6\   $��1��6m   $��Center=�6z   $��24��6�   $��57��6�   �� 5     -F   5        $
 nameTextBox1��5  "   $��1��68   $
��Left=�6H   $��23��6c   $��2.8,5.2,0,5.4q�6o   $��1��6�   $��Center=�6�   $	��120��6  ��6�   �� *Name+$ TwoWay=� . 	 . 6  �� 5     $��	Per Hour:��6    $��0��64   $
��Left=�6D   $��
-1,5.4,0,5q�6_   $��10��6s   $��Center=�6�   $��24��6�   $��59��6�   �� 5     -G   5        $
 perHourTextBox1��5  "   $
��Left=�6;   $��23��6V   $��
63,5.4,0,6q�6b   $��10��6v   $��Center=�6�   $��44��6�   ��6�   �� *	PerHour+$ TwoWay=� . 	 . 6�   �� 5     $��
Per Month:��6    $��1��65   $
��Left=�6E   $��3.8,5.4,0,5q�6`   $��10��6u   $��Center=�6�   $��24��6�   $��69��6�   �� 5      -H   5        $
 perMonthTextBox1��5   "   $��1��6<   $
��Left=�6L   $��23��6g   $��90.8,6.4,0,5q�6s   $��10��6�   $��Center=�6�   $��46��6  ��6�   �� *
PerMonth+$ TwoWay=� . 	 . 6  �� 5!     $��Phone:��6    $��0��61   $
��Left=�6A   $��
-1,4.2,0,6q�6\   $��7��6p   $��Center=�6}   $��25��6�   $��46��6�   �� 5"     -I   5        $
 phoneTextBox1��5"  "   $��1��69   $
��Left=�6I   $��23��6d   $��3.8,6.2,0,6q�6p   $��7��6�   $��Center=�6�   $	��120��6  ��6�   �� *Phone+$ TwoWay=� . 	 . 6  �� 5#     $��Years Of Experience:��6    $��0��6?   $
��Left=�6O   $��	3,5.2,0,4q�6j   $��14��6}   $��Center=�6�   $	��120��6�   $��26��6�   �� 5$     -J   5        $
 yearOfExperienceTextBox1��5$  "   $
��Left=�6D   $��23��6_   $��2.8,8.2,0,4q�6k   $��14��6�   $��Center=�6�   $��32��6  $��1��6  ��6�   �� *YearOfExperience+$ TwoWay=� . 	 . 6  �� 5%     $��Recommendations:��6    $��2��6;   $
��Left=�6K   $��0.2,5.8,0,33q�6f   $��Center=�6|   $��30��6�   $��13��6�   $��2��6�   $	��110��6�   �� 5&     -K   5        $
 recommendationsTextBox1��5&  "   $
��Left=�6C   $	��161��6^   $��113.2,33.4,-144,10.4q�6k   $��Center=�6�   $	��194��6  $��2��6  $��12��6(  $��6��66  ��6�   �� *Recommendations+$ TwoWay=� . 	 . 66  �� 5'     $&�� Vacation Days Through The TAMAT?��6    $��2��6K   $
��Left=�6[   $��0.2,1.4,-37,6.8q�6v   $��Center=�6�   $��27��6�   $	��200��6�   $��4��6�   �� 5(     -L   5        $ vacDaysCheckBox1��5(  #   $�� ��6=   $
��Left=�6H   $��224.2,10.4,-79,7.8q�6�   $��Center=�6�   $��2��6�   $��17��6  $��18��6  $��4��6&   6c   �� *	VacDays+$ TwoWay=� . 	 . 6&  �� 5)     $��Smokes:��6    $��2��62   $
��Left=�6B   $��0.2,4.4,0,7q�6]   $��Center=�6r   $��66��6�   $��23��6�   $��2��6�   �� 5*     -M   5        $ smokesCheckBox1��5*  #   $�� ��6<   $
��Left=�6G   $��118.2,12.4,0,2q�6�   $��Center=�6�   $��2��6�   $��20��6	  $��21��6  $��2��6    6b   �� *Smokes+$ TwoWay=� . 	 . 6   �� 5+     $��Drinks Alcool:��6    $��2��69   $
��Left=�6I   $��0.2,4,0,2.6q�6d   $��Center=�6y   $��27��6�   $��3��6�   $��81��6�   �� 5,     -N   5        $ drinksAlcoolCheckBox1��5,  #   $�� ��6B   $
��Left=�6M   $��118.2,9,0,2.6q�6�   $��2��6�   $��26��6�   $��3��6   6h   �� *DrinksAlcool+$ TwoWay=� . 	 . 6  �� 5-     -O   5        $ religionNComboBox1��5-  #   $
��Left=�6?   $��23��6Z   $��118.2,6,-88,5.4q�6f   $��Center=�6�   $	��133��6�   $��2��6�    6   �� *	ReligionN+6�   �� 5.     $��Religion Nanny:��6    $��2��6:   $
��Left=�6J   $��0.2,4,0,2.8q�6e   $��Center=�6z   $��26��6�   $��93��6�   �� 5/     $��*Available Work Days:��6    $��1��6@   $
��Left=�6P   $��160.8,2.2,0,0q�6k   $	��Top=�6�   $��31��6�   $	��164��6�   $��7��6�   $��2��6�   �� 50     -P   5        $ SundayCheckBox1��50  #   $��2��6<   $��8��6L   $��Sunday��6Y   $
��Left=�6j   $��	10,10,0,0q�6�   $	��Top=�6�   $��10(�6  $��16��6%  $��53��61   6�   �� *	Worked[0]+$ TwoWay=� . 	 . 61  �� 51     -Q   5        $ MondayCheckBox1��51  #   $��2��6<   $��8��6L   $��Monday��6Y   $
��Left=�6j   $��	83,10,0,0q�6�   $	��Top=�6�   $��10(�6�   $��16��6%  $��56��61   6�   �� *	Worked[1]+$ TwoWay=� . 	 . 61  �� 52     -R   5        $ TuesdayCheckBox1��52  #   $��2��6=   $��8��6M   $��Tuesday��6Z   $
��Left=�6l   $��173,10,-66,0q�6�   $	��Top=�6�   $��10(�6�   $��16��6*  $��56��66   6�   �� *	Worked[2]+$ TwoWay=� . 	 . 66  �� 53     -S   5        $ WednesdayCheckBox1��53  #   $��2��6?   $��9��6O   $��	Wednesday��6\   $
��Left=�6p   $��9,10,0,0q�6�   $	��Top=�6�   $��10(�6�   $��15��6+  $��72��67   6�   �� *	Worked[3]+$ TwoWay=� . 	 . 67  �� 54     -T   5        $ ThursdayCheckBox1��54  #   $��2��6>   $��9��6N   $��Thursday��6[   $
��Left=�6n   $��	86,10,0,0q�6�   $	��Top=�6�   $��10(�6�   $��15��6)  $��60��65   6�   �� *	Worked[4]+$ TwoWay=� . 	 . 65  �� 55     -U   5        $ FridayCheckBox1��55  #   $��2��6<   $��9��6L   $��Friday��6Y   $
��Left=�6j   $	��Top=�6�   $��173,10,-66,0q�6�   $��10(�6�   $��14��6)  $��56��65   6�   �� *	Worked[5]+$ TwoWay=� . 	 . 65  �� 56     -V   5        $ SaturdayCheckBox1��56  #   $��2��6>   $��9��6N   $��Saturday��6[   $
��Left=�6n   $	��Top=�6�   $��242,10,-144,0q�6�   $��10(�6�   $��65��6-  $��15��68   6�   �� *	Worked[6]+$ TwoWay=� . 	 . 6D  � 58     $
��Left=�6   $��86��6:   $��0.2,5.4,-186,0q�6F   $	��Top=�6^   $	��349��6v   $��2��6�   $��10��6�   $��3��6�    59     �� 5:  "   $��* �60   �� 5;  "   $��* �60   �� 5<  "   $��* �60    5>     �� 5?  "   $��* �63   �� 5@  "   $��* �63   �� 5A  "   $��* �63   �� 5B  "   $��* �63   �� 5C  "   $��* �63   �� 5D  "   $��* �63   �� 5E  "   $��* �63   �� 5F  "   $��* �63   .+�5I     �� $	��Sun��6$   $��1��62   $��Center=�6B   $��Bottom=�6`   $��10(�6{   $��	8,0,8,0.2q�6�   �� 5J     $	��Mon��6$   $��2��62   $��Center=�6B   $��Center=�6_   $��10(�6z   �� 5K     $
��Tues��6$   $��3��63   $��Center=�6C   $��Center=�6a   $��10(�6|   �� 5L     $
��Wedn��6$   $��4��63   $��Center=�6C   $��Center=�6`   $��10(�6{   �� 5M     $��Thurs��6$   $��5��64   $��Center=�6D   $��Center=�6a   $��10(�6|   �� 5N     $	��Fri��6$   $��6��62   $��Center=�6B   $��Center=�6`   $��10(�6{   �� 5O     $	��Sat��6$   $��7��62   $��Center=�6B   $��Center=�6`   $��10(�6{   �� 5P     $��Begin��6$   $��Center=�64   $��1��6R   $��Center=�6_   $��10(�6z   �� 5Q     $	��End��6$   $��Center=�62   $��2��6P   $��Center=�6]   $��10(�6x   �� 5T     -W   5        $ SundayComboBoxBegin1��5T  '   $��Stretch=�6E   $��Bottom=�6c   $��29��6�   $��43,0,0.2,28.4q�6  $��2��6  $��1��60  $��2��6=  {�6�   �� $ SundayCheckBox1��$ 	IsChecked�6=  �� 5U     -X   5        $ MondayComboBoxBegin1��5U  '   $��2��6E   $��Stretch=�6U   $��1��6s   $��Stretch=�6�   {�6�   �� $ MondayCheckBox1��$ 	IsChecked��� 5V     -Y   5        $ TuesdayComboBoxBegin1��5V  '   $��3��6F   $��Stretch=�6V   $��1��6t   $��Stretch=�6�   {�6�   �� $ TuesdayCheckBox1��$ 	IsChecked��� 5W     -Z   5        $ WednesdayComboBoxBegin1��5W  '   $��4��6H   $��Stretch=�6X   $��1��6v   $��Stretch=�6�   {�6�   �� $ WednesdayCheckBox1��$ 	IsChecked��� 5X     -[   5        $ ThursdayComboBoxBegin1��5X  '   $��5��6G   $��Stretch=�6W   $��1��6u   $��Stretch=�6�   {�6�   �� $ ThursdayCheckBox1��$ 	IsChecked��� 5Y     -\   5        $ FridayComboBoxBegin1��5Y  '   $��6��6E   $��Stretch=�6U   $��1��6t   $��Stretch=�6�   {�6�   �� $ FridayCheckBox1��$ 	IsChecked��� 5Z     -]   5        $ SaturdayComboBoxBegin1��5Z  '   $��7��6G   $��Stretch=�6W   $��1��6u   $��Stretch=�6�   {�6�   �� $ SaturdayCheckBox1��$ 	IsChecked��� 5\     -^   5        $ SundayComboBoxEnd1��5\  '   $��1��6C   $��Stretch=�6S   $��2��6q   $��Stretch=�6~   {�6�   �� $ SundayCheckBox1��$ 	IsChecked��� 5]     -_   5        $ MondayComboBoxEnd1��5]  '   $��2��6C   $��Stretch=�6S   $��2��6r   $��Stretch=�6   {�6�   �� $ MondayCheckBox1��$ 	IsChecked��� 5^     -`   5        $ TuesdayComboBoxEnd1��5^  '   $��3��6D   $��Stretch=�6T   $��2��6r   $��Stretch=�6   {�6�   �� $ TuesdayCheckBox1��$ 	IsChecked��� 5_     -a   5        $ WednesdayComboBoxEnd1��5_  '   $��4��6F   $��Stretch=�6V   $��2��6t   $��Stretch=�6�   {�6�   �� $ WednesdayCheckBox1��$ 	IsChecked��� 5`     -b   5        $ ThursdayComboBoxEnd1��5`  '   $��5��6E   $��Stretch=�6U   $��2��6s   $��Stretch=�6�   {�6�   �� $ ThursdayCheckBox1��$ 	IsChecked��� 5a     -c   5        $ FridayComboBoxEnd1��5a  '   $��6��6C   $��Stretch=�6S   $��2��6q   $��Stretch=�6~   {�6�   �� $ FridayCheckBox1��$ 	IsChecked��� 5b     -d   5        $ SaturdayComboBoxEnd1��5b  '   $��7��6E   $��Stretch=�6U   $��2��6s   $��Stretch=�6�   {�6�   �� $ SaturdayCheckBox1��$ 	IsChecked�5d     5g     5l     5m     �� 5n     $��Remove��6   .��5o     � .+�5p     �� $��Center=�6   $��20(�6@   $3��- Choose which nanny would you like to remove?��6N   $
��Left=�6�   $��
135,89,0,0q�6�   $	��Top=�6�   $	��449��6�   $��37��6�   �� 5q     -e   5        $��Remove��5q     $��Remove��6,   $��Center=�6=   $��314,244,270.4,0q�6Z   $	��Top=�6s   $��90��6�   $��20(�6�   $��30��6�   �� 5r     $��20(�6   $	��Id:��6*   $
��Left=�68   $��135,174,0,456.2q�6S   $��0��6l   $��Center=�6y   $��47��6�   $��45��6�   �� 5s     -f   5        $ removeidComboBox��5s      �� DisplayMemberPath$ Id��69   $
��Left=�6P   $��38��6k   $��216,174,0,463.2q�6�   $��0��6�   $��Center=�6�   $	��300��6�   ��6w   �� ��5t     �� 5u     .R�5v  "   $� 5w     5y     5{     5|     5     5�     5�     