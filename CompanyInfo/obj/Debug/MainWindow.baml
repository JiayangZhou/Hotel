   M S B A M L   `   `   `  ����F  BCompanyInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CompanyInfoCompanyInfo  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       CompanyInfo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CompanyInfo     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   $��18(�5        � Topmost  .   � WindowState$ Normal=�68    � Title$ CompanyInfo��5	   	   $	��450��6   $	��800��6*   .��5      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� -   5         ��Name$ 
tabControl��5      $��1��6)   $��4��69   $	��200��6F   $	��300��6V   .@�5       �� $
��Draw��6   .��5!      � ���	#FFE5E5E56   5"      �� 5#      $��Calendar��6   .��5$      � ���	#FFE5E5E5.+�5%      &   System.Windows.Controls.Calendar  -   5        $��
MyCalendar��5%      $
��Left=�61   
�������   DisplayMode$ Month=�6c      DisplayDateStart$ 3/1/2017X�6w      DisplayDateEnd$ 	12/1/2018X�6�   	   FirstDayOfWeek$	 Monday=�6�   
   SelectedDate$
 
10/21/2019X�5(   1   5)      �� 5*      -   5         ��Name$ tbDataSelected��5*       �� TextWrapping$
 Wrap=�66   $��TextBox��6J   $��Right=�6Y   $��Bottom=�6u   5+      5,      �� 5-      $��TabItem��6   .��5.      � ���	#FFE5E5E56   5/      50      �� 52   
   $(��"Type the property you wanna check:��6   $��1��6>   $��1��6N   $��20(�6[   $��SemiBold"�6i   $��0,0,10,0q�6   $��3��6�   �� 53   
   -   5        $ propertyName��53      $��1��6(   $��2��68   �� 54   
   -   5         ��Name$ 
okayButton��54      $
��Okay��6%   $��1��64   $��3��6D   $��	40,0,40,0q�6Q   6d   �� 55   
   -   5         ��Name$ 
properties��55      $��2��6'   $��2��67   $��2��6D   ��56      �� 57      .R�58      ��  �� Orientation$ 
Horizontal=�6!   .+�59      �� $N��HC:\Users\dengd\OneDrive\桌面\Sweden\Certification\Personal Info\me.png��6    $��20��6n   $��20��6z   �� 5:      ��6$   �� *
FullName+5;      5<      5>      �� 5P   
   $��4��6   $��2��6'   $��4��64   .��5Q      �� $ Vertical=�6   .+�5R      �� $	��200��6   $	��300��6(   $,��&C:\Life\Desktop background\Guidao3.jpg��67   �� 5S      $	��200��6   $	��300��6(   $,��&C:\Life\Desktop background\Guidao4.jpg��67   �� 5T      $	��200��6   $	��300��6(   $,��&C:\Life\Desktop background\Guidao5.jpg��67   5U      5V      5X      5Y      