   M S B A M L   `   `   `  ����C  ?MovieNet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MovieNet.ViewsMovieNet.Views  5          MovieNet.Views.MovieView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:MovieNet.Views     5      .��5      � $��5,8,8,0q�6     � ColumnDefinitions  5	   
   �� 5
      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��Movie Management��6   $��0��6,   $��0��69   $��2��6I   $��30(�6]   $
��Bold"�6k   $��Center=�6}   $	��5,8q�6�   �� 5   
   $��Entre Id��6   $��1��6$   $��0��61   $��20(�6A   $	��5,8q�6O    �� Padding$ 3q�6\   �� 5   
   $��Entre Title��6   $��2��6'   $��0��64   $��20(�6D   $	��5,8q�6R   $ 3q�6_   �� 5   
   $��Entre Resume��6   $��3��6(   $��0��65   $��20(�6F   $	��5,8q�6T   $ 3q�6a   �� 5   
   $��Entre Genre��6   $��4��6'   $��0��64   $��20(�6D   $	��5,8q�6R   $ 3q�6_   �� 5   
   -   5        $��txtId��5      $��1��6   $��1��6,   $	��5,8q�6<   $��3q�6I   ��6U   ��  �� Path$ CurrentMovie.Id� �� Mode$ TwoWay=��� 5   
   -   5        $��txtTitre��5      $��2��6"   $��1��6/   $	��5,8q�6?   $��3q�6L   ��6X   �� $ CurrentMovie.Titre�$ TwoWay=��� 5   
   -   5        $��	txtResume��5      $��3��6#   $��1��60   $	��5,8q�6@   $��3q�6M   ��6Y   �� $ CurrentMovie.Resume�$ TwoWay=��� 5   
   -   5        $��txtGenre��5      $��4��6"   $��1��6/   $	��5,8q�6?   $��3q�6L   ��6X   �� $ CurrentMovie.Genre�$ TwoWay=��� 5    
    �� Orientation$ 
Horizontal=�6   $��5��6.   $��1��6;   $	��5,8q�6K   .+�5!      �� -   5        $��btnAdd��5!      $	��ADD��6#   $	��5,8q�61   $��3q�6>   ��6J   �� $ SaveCommand��� 5"      -   5        $��	btnsearch��5"      $��SEARCH��6&   $	��5,8q�67   $��3q�6D   ��6P   �� $ SearchCommand��� 5#      -   5        $��	btnUpdate��5#      $��UPDATE��6&   $	��5,8q�67   $��3q�6D   ��6P   �� $ UpdateCommand��� 5$      -   5        $��	btnDelete��5$      $��DELETE��6&   $	��5,8q�67   $��3q�6D   ��6P   �� $ DeleteCommand�5%      �� 5&   
   -	   5        $��txtBlockMessage��5&      $��5��6+   $��1��68   $	��5,8q�6H    �� 
LineHeight$ 11��6U   ��6e   �� $ Message�&   System.Windows.Controls.DataGrid  5'   
   -
   5        $��dgMovies��5'         AutoGenerateColumns .  $��6��6?   $��1��6L   $ ��5.333,69.667,4.667,-53.667q�6�   ��6�   �� $ 
MoviesList�$ TwoWay=�   Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Movie Id��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 auto 67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� $ Id�6b     5*      $	 Movie Titre��6%   $

 auto 6:    6G   �� $ Titre�6h     5+      $	 Movie Resume��6%   $

 auto 6;    6H   �� $ Resume�6j     5,      $	 Movie Genre��6%   $

 auto 6:    6G   �� $ Genre�6h   5.      50      51      