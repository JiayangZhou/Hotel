   M S B A M L   `   `   `  ����D  @CompanyUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CompanyUI.ViewsCompanyUI.Views  5   	       CompanyUI.Views.ShellView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:CompanyUI.Views     5   	   $��18(�5        � Title$  	ShellView��5   	   $	��450��6   $	��800��6(   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6@   $��1��6P   $��2��6]   ��6   ��  �� Path$ FullName� �� Mode$ OneWay=�6]   �� 5   
   -   5         ��Name$ 	FirstName��5   =   $��80��6   $��1��6    $��2��60   6=   �� 5    
   -   5        $ LastName��5    =   $��80��6   $��2��6    $��2��60   6=   �� 5!   
   -   5         ��Name$ People��5!   P   $��3��6   $��1��6#   $��3��60   $	��150��6A    �� DisplayMemberPath$ 	FirstName��6�    �� SelectedItem 6`   �� $ SelectedPerson�$ OneWayToSource=�6�   �� 5"   
   -   5        	 ��Name$	 Clear��5"      $��4��6    $��1��60   $��Clear��6=   �� 5#   
   -   5        
 ��Name$
 
ActiveItem��5#      $	��300��6-   $��4��6=   $��1��6J   $��4��6Z   �� 5$   
   -   5        $	 LoadPageOne��5$      $��LoadFirstPage��6&   $��4��6>   $��2��6N   �� 5%   
   -   5        $	 LoadPageTwo��5%      $��LoadSecondPage��6&   $��4��6?   $��3��6O   5&      5'      