   M S B A M L   `   `   `  ����H  DLecture33_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Lecture33_wpfLecture33_wpf  5   	       Lecture33_wpf.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Lecture33_wpf     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	      !  Lecture33_wpf.CoverterClass   myConverter��%   &	          5
   
   64   5      .��5      �  � ShowGridLines$ False��6   $��Center=�6"   $��Center=�6@    � ColumnDefinitions 5   
   �� 5      $	��100��6   $	��200��6.   6@   �� 5      $	��200��6   $	��400��6.   6@    � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6-   .+�5   
   �� $��Center=�6   $��Center=�64   $��0��6V   $��0��6c   $��
First Name��6s   ���	#FFF09898$��18(�6�   $��0,0,5,5q�6�   6�   �� 5   
   $��Center=�6   $��Center=�64   $��1��6V   $��0��6c   $��	Last Name��6s   ���	#FFF09898$��18(�6�   $��0,0,5,5q�6�   6�   �� 5   
   -   5        $��txtFirstName��5      $��0��6&   $��1��63   ���	#FF50EFFF$��0,0,0,5q�6Z   6n   �� 5   
   -   5        $��txtLastName��5      $��1��6%   $��1��62   ���	#FF50EFFF$��0,0,0,5q�6Y   6m   �� 5   
   -   5        $��btnSave��5      $��2��6    $��0��64   $��2��6D   $
��Save��6Q   $��50��6`   {�5      `� 5       `� 	Converter# [  6   .1�5      ��  �� ElementName$ txtFirstName��6    �� Path$
 Text�69   6G   �� 5      $ txtLastName��6   $
 Text�68   6F   5       5$      5%      5&      