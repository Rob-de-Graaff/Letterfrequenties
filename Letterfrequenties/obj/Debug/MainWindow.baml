   M S B A M L   `   `   `  ����L  HLetterfrequenties, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:LetterfrequentiesLetterfrequenties  5   	   "    Letterfrequenties.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Letterfrequenties     5   	     � Title$  Frequenties��5   	   $��186.8��6   $	��800��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��25.6 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ labelSearchBar��5      $��
Search Bar��6(   $��0��6=   $��0��6J   �� 5   
   -   5         ��Name$ textboxSearchBar��5      $��0��6,   $��1��69   $��2��6I   �� 5   
   -   5        $ textboxResult��5      $��0��6)   $��3��66   $��1��6F    �� 
IsReadOnly . 6Z   �� 5   
   -   5        $ labelSearchResults��5      $��Search Results��6,   $��1��6E   $��0��6R   �� 5   
   -   5        $ textboxSearchResults��5      $��1��60   $��1��6=   $��4��6M   $��3��6^    �� MinLines$ 10��6r    �� TextWrapping$
 Wrap=�6�   �� 5    
   -   5         ��Name$ buttonImportFile��5       $��Import��6+   $��2��6<   $��0��6I   $
��Left=�6Y   $��
10,5.2,0,0q�6t   $	��Top=�6�   $��66��6�   6�   �� 5!   
   -   5        $ buttonSearch��5!      $��Search��6'   $��3��68   $��0��6E   $
��Left=�6U   $��
10,2.8,0,0q�6p   $	��Top=�6�   $��66��6�   6�   �� 5"   
   -   5        	 ��Name$	 checkboxCapitalLetter��5"      $��Capital
Letter��62   $��4��6O   $��0��6\   $
��Left=�6l   $��10,4.4,0,-8q�6�   $	��Top=�6�   $��66��6�   $��30��6�   5$      5%      