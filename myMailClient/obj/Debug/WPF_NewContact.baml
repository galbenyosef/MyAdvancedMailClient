   M S B A M L   `   `   `  ����G  CmyMailClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:myMailClientmyMailClient  5   	   !    myMailClient.WPF_NewContact   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:myMailClient     5   	     � Title$  WPF_NewContact��5   	   $	��300��6    $	��300��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6!   $
��Name��61   6?   �� 5   
   $��1��6   $��0��6!   $��Mail Address��61   6G   �� 5   
   $��0��6   $��1��6   ��6/   �� *	NewName+6J   �� 5   
   $��1��6   $��1��6   ��6/   �� *	NewMail+6J   �� 5   
   -   5        $��btn_add_contact��5      $��Add..��6(   $��1��68   $��2��6H   $
��Left=�6U   6�   5      5      