   M S B A M L   `   `   `  ����G  CmyMailClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:myMailClientmyMailClient  5   	   !    myMailClient.WPF_NewMessage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:myMailClient     5   	     � Title$  WPF_NewMessage��5   	   $	��300��6    $	��300��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Subject��6   $��0��6#   $��0��60   6B   �� 5   
   $��To��6   $��1��6   $��0��6+   6=   �� 5   
   -   5        $	��Add��5      $	��Top=�6   $��1��67   $��1��6D   6f   �� 5   
   $
��Body��6   $��2��6    $��0��6-   6?   �� 5   
   -   5        $
��Done��5      $��3��6    $��1��6-   6P   �� 5   
   $��0��6+   $��2��68   ��6   �� *	Subject+6J   �� 5   
   $��1��6-   $��2��6:   $��1��6J   ��6   �� *To+��5      �� 5      .R�5      ��  �� Orientation$ Vertical=�6!   .+�5      �� $��24(�6:   $��Oblique$�6H   ��6$   �� *Name+6^   �� 5       $��18(�6A   ��6$   �� *MailAddress+6Q   5!      5"      5$      �� 5%   
   $
��Auto=�6    �� TextWrapping$
 Wrap=�6B   $��2��6l   $��2��6y   ��6V   �� *Body+6�   5&      5'      