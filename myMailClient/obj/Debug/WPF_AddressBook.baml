   M S B A M L   `   `   `  ����G  CmyMailClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:myMailClientmyMailClient  5   	   "    myMailClient.WPF_AddressBook   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:myMailClient     5   	     � Title$  AddressBookWindow��5   	   $	��300��6#   $	��300��60   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Search��6   $��0��6"   $��0��6/   6A   �� 5   
   -   5        $��
SearchText��5      $��0��6$   $��1��61   6_   �� 5   
   -   5        $	��Top=�5      $��New...��6)   $��1��6:   $��0��6G   6i   �� 5   
   -   5        $	��Top=�5      $��Remove��6)   $��2��6:   $��0��6G   6l   �� 5   
   -   5        $	��Top=�5      $��Select��6)   $��3��6:   $��0��6G   6l   �� 5   
   -   5        $��contact_list��5      $��1��6i   $��2��6v   $��3��6�   ��6&   �� *
Contacts+ �� SelectedItem 6G   �� *
Selected+��5      �� 5      .R�5      ��  �� Orientation$ Vertical=�6!   .+�5      �� $��24(�6:   $��Oblique$�6H   ��6$   �� *Name+6^   �� 5      $��18(�6A   ��6$   �� *MailAddress+6Q   5      5       5"      5#      5$      