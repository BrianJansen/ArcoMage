   M S B A M L   `   `   `  ����C  ?ArcoMage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ArcoMageArcoMage  5   	   9!clr-namespace:ArcoMage.ConvertersArcoMage.Converters  5   	       ArcoMage.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ArcoMage     5   	   8
converters!clr-namespace:ArcoMage.Converters     5   	     � WindowState$  	Maximized=�5	   	    � WindowStyle$
 None=�5
   	    � Title$ 
MainWindow��5   	   $
��1080��6   $
��1920��6*    � 	Resources 5      .   (ArcoMage.Converters.TowerHeightConverter   towerHeightConverter-   'ArcoMage.Converters.WallHeightConverter  wallHeightConverter��%:   &	        &	        5   
   6*     5   
   6)   5      .��5      � -   5        .+�5   
   � -   5         �Name$ GameGrid��5      .+�5      � -   5        $ PlayArea��5      $	��Top=�6%   $	��780��6=   .+�5      �� $L��Fpack://application:,,,/ArcoMage;component/Images/MagicalBackground.jpg��6   $
��Fill=�6h   5      � 5      -   5        $ P1Resources��5      $
��Left=�6(   $	��Top=�6C   $	��780��6[   $	��300��6h   .+�5      �� $L��Fpack://application:,,,/ArcoMage;component/Images/ResourcesBackdrop.jpg��6   $
��Fill=�6h   � 5      -   5        $ P1BrickLabel��5      $	��200��6-   $	��200��6:   $��	0,0,0,500q�6F   .+�5      �� $D��>pack://application:,,,/ArcoMage;component/Images/BrickIcon.png��6   $
��Fill=�6d   �� 5      -   5         ��Name$ P1CurrentBrickCount��5       $��82(�6�   $
��Bold"�6�   
���2͚�$	��100��6�   $	��150��6�   $
��Left=�6�   $��Bottom=�6�   ��6=   �� *Player1.BrickQuantity+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      -   5        $ P1CurrentBrickProduction��5       $��32(�6�   $
��Bold"�6�   
����� �$��50��6�   $��50��6�   $��Right=�6�   $��Bottom=�6�   ��6B   �� *Player1.BrickLevel+$ PropertyChanged=�6�   5      � 5      -   5        $ P1MagicLabel��5      $	��200��6-   $	��200��6:   $��0,0,0,0q�6F   .+�5      �� $D��>pack://application:,,,/ArcoMage;component/Images/MagicIcon.png��6   $
��Fill=�6d   �� 5      -	   5        $ P1CurrentMagicCount��5       $��82(�6�   $
��Bold"�6�   
���2͚�$	��100��6�   $	��150��6�   $
��Left=�6�   $��Bottom=�6�   ��6=   �� *Player1.MagicQuantity+$ PropertyChanged=�6�   �� 5       -
   5        $ P1CurrentMagicProduction��5        $��32(�6�   $
��Bold"�6�   
����� �$��50��6�   $��50��6�   $��Right=�6�   $��Bottom=�6�   ��6B   �� *Player1.MagicLevel+$ PropertyChanged=�6�   5!      � 5"      -   5        $ P1DungeonLabel��5"      $	��200��6/   $	��200��6<   $��
0,0,0,-500q�6H   .+�5#      �� $F��@pack://application:,,,/ArcoMage;component/Images/DungeonIcon.png��6   $
��Fill=�6f   �� 5$      -   5        $ P1CurrentDungeonCount��5$       $��82(�6�   $
��Bold"�6�   
���2͚�$	��100��6�   $	��150��6�   $
��Left=�6�   $��Bottom=�6�   ��6?   �� *Player1.DungeonQuantity+$ PropertyChanged=�6�   �� 5%      -   5        $  P1CurrentDungeonProduction��5%       $��32(�6�   $
��Bold"�6�   
����� �$��50��6�   $��50��6�   $��Right=�6�   $��Bottom=�6�   ��6D   �� *Player1.DungeonLevel+$ PropertyChanged=�6�   5&      5(      � 5)      -   5        $ P2Resources��5)      $��Right=�6(   $	��Top=�6D   $	��780��6\   $	��300��6i   .+�5*      �� $L��Fpack://application:,,,/ArcoMage;component/Images/ResourcesBackdrop.jpg��6   $
��Fill=�6h   � 5+      -   5        $ P2BrickLabel��5+      $	��200��6-   $	��200��6:   $��	0,0,0,500q�6F   .+�5,      �� $D��>pack://application:,,,/ArcoMage;component/Images/BrickIcon.png��6   $
��Fill=�6d   �� 5-      -   5        $ P2CurrentBrickCount��5-       $��82(�6�   $
��Bold"�6�   
���2͚�$	��100��6�   $	��150��6�   $
��Left=�6�   $��Bottom=�6�   ��6=   �� *Player2.BrickQuantity+$ PropertyChanged=�6�   �� 5.      -   5        $ P2CurrentBrickProduction��5.       $��32(�6�   $
��Bold"�6�   
����� �$��50��6�   $��50��6�   $��Right=�6�   $��Bottom=�6�   ��6B   �� *Player2.BrickLevel+$ PropertyChanged=�6�   5/      � 50      -   5        $ P2MagicLabel��50      $	��200��6-   $	��200��6:   $��0,0,0,0q�6F   .+�51      �� $D��>pack://application:,,,/ArcoMage;component/Images/MagicIcon.png��6   $
��Fill=�6d   �� 52      -   5        $ P2CurrentMagicCount��52       $��82(�6�   $
��Bold"�6�   
���2͚�$	��100��6�   $	��150��6�   $
��Left=�6�   $��Bottom=�6�   ��6=   �� *Player2.MagicQuantity+$ PropertyChanged=�6�   �� 53      -   5        $ P2CurrentMagicProduction��53       $��32(�6�   $
��Bold"�6�   
����� �$��50��6�   $��50��6�   $��Right=�6�   $��Bottom=�6�   ��6B   �� *Player2.MagicLevel+$ PropertyChanged=�6�   54      � 55      -   5        $ P2DungeonLabel��55      $	��200��6/   $	��200��6<   $��
0,0,0,-500q�6H   .+�56      �� $F��@pack://application:,,,/ArcoMage;component/Images/DungeonIcon.png��6   $
��Fill=�6f   �� 57      -   5        $ P2CurrentDungeonCount��57       $��82(�6�   $
��Bold"�6�   
���2͚�$	��100��6�   $	��150��6�   $
��Left=�6�   $��Bottom=�6�   ��6?   �� *Player2.DungeonQuantity+$ PropertyChanged=�6�   �� 58      -   5        $  P2CurrentDungeonProduction��58       $��32(�6�   $
��Bold"�6�   
����� �$��50��6�   $��50��6�   $��Right=�6�   $��Bottom=�6�   ��6D   �� *Player2.DungeonLevel+$ PropertyChanged=�6�   59      5:      �� 5;      $
��Left=�6   $��Bottom=�64   $��500,300q�6O   .+�5<      �� $B��<pack://application:,,,/ArcoMage;component/Images/WallPic.png��6   $
��None=�6^   $��30��6�   ��6m   �� *Player1.WallLevel+ �� 	Converter# [ 6�   �� 5=      
�������$��30��6/   $��30��6;   $��	0,-40,0,0q�6F   $
��Bold"�6|    �� TextAlignment$ Center=�6�   $��16(�6�   ��6Y   �� *Player1.WallLevel+6�   5>      �� 5?      	 �� Orientation$	 Vertical=�6   $
��Left=�60   $��Bottom=�6K   $��400,0,0,300q�6f   .+�5@      �� $E��?pack://application:,,,/ArcoMage;component/Images/P1TowerTop.png��6   $
��Fill=�6a   $��60��6p   $��60��6|   $��0,0,0,-6q�6�   $
��Left=�6�   $��Bottom=�6�   �� 5A      $C��=pack://application:,,,/ArcoMage;component/Images/TowerPic.jpg��6   $
��None=�6_   $��60��6�   $
��Left=�6�   $��Bottom=�6�   ��6n   �� *Player1.TowerLevel+# [  6�   �� 5B      
�������$��30��6/   $��50��6;   $��	0,-40,0,0q�6F   $
��Bold"�6}   $ Center=�6�   $��16(�6�   ��6Y   �� *Player1.TowerLevel+6�   5C      �� 5D      $��500,300q�6   $��Right=�6*   $��Bottom=�6F   .+�5E      �� $B��<pack://application:,,,/ArcoMage;component/Images/WallPic.png��6   $
��None=�6^   $��30��6�   ��6m   �� *Player2.WallLevel+# [ 6�   �� 5F      
�������$��30��6/   $��30��6;   $��	0,-40,0,0q�6F   $
��Bold"�6|   $ Center=�6�   $��16(�6�   ��6Y   �� *Player2.WallLevel+6�   5G      �� 5H      $	 Vertical=�6   $��Right=�60   $��Bottom=�6L   $��0,0,400,300q�6g   .+�5I      �� $E��?pack://application:,,,/ArcoMage;component/Images/P2TowerTop.png��6   $
��Fill=�6a   $��60��6p   $��60��6|   $��0,0,0,-6q�6�   $
��Left=�6�   $��Bottom=�6�   �� 5J      $C��=pack://application:,,,/ArcoMage;component/Images/TowerPic.jpg��6   $
��None=�6_   $��60��6�   $
��Left=�6�   $��Bottom=�6�   ��6n   �� *Player2.TowerLevel+# [  6�   �� 5K      
�������$��30��6/   $��50��6;   $��	0,-40,0,0q�6F   $
��Bold"�6}   $ Center=�6�   $��16(�6�   ��6Y   �� *Player2.TowerLevel+6�   5L      �� 5M      $	��150��6   $	��150��6"   $��Center=�6N   $��Center=�6k   $��	0,0,0,400q�6�   ��6.   �� *TestButton1+6�   �� 5N      $	��150��6   $	��150��6"   $��Center=�6N   $��Center=�6k   ��6.   �� *TestButton2+6k   �� 5O      $	��150��6   $	��150��6"   $��Center=�6N   $��Center=�6k   $��
0,0,0,-400q�6�   ��6.   �� *TestButton3+6�   � 5P      -   5        $ CardTray��5P      $��Bottom=�6%   $	��300��6@   .+�5Q      �� $C��=pack://application:,,,/ArcoMage;component/Images/CardTray.jpg��6   $
��Fill=�6_   �� 5R      ��6   �� *Player1.Hand+$ PropertyChanged=�y�6i   �� *Player1Visibility+��5S      �� 5T      .R�5U      �� 
 ��Name$
 Cards��6)   $
��Left=�68   $	 
Horizontal=�6S   5V      ��5X      �� 5Y      .R�5Z      �� $	��250��6%   $	��200��62   $��	100,0,0,0q�6>   ��6Q   �� ��6n   ��  �� RelativeSource ��  �� AncestorType" �� �� Path$ DataContext.CardSelected�.��5[   "   � .+�5\   &   �� $I��Cpack://application:,,,/ArcoMage;component/Images/CardBackground.jpg��6,   $
��Fill=�6y   �� 5]   &   
�������$��Right=�6�   $	��Top=�6�   $��30��6�   $��30��6�   $
��Bold"�6�   $��22(�6�   ��6C   �� *
CostAmount+$ PropertyChanged=���6�   �� *	CostColor+$ PropertyChanged=��� 5^   &   $	 Vertical=�61   $��Center=�6H   $	��Top=�6e   $	��200��6}   $	��150��6�   .+�5_   *   �� $��20��64   $
��Bold"�6@   $��16(�6R   
��� ���$ Center=�6t   $��15q�6�   ��6�   �� *
CardName+$ PropertyChanged=�6�   �� 5`   *   $
��Fill=�6n   $	��100��6}   $	��140��6�   $��5,0,5,0q�6�   ��60   �� *Image+$ PropertyChanged=�6�   �� 5a   *   $
��Wrap=�6v   
��� ���$��5q�6�   ��64   �� *Description+$ PropertyChanged=�6�   5b   '   5c   #   5d      5e      5g      �� 5h      ��6   �� *Player2.Hand+$ PropertyChanged=�y�6i   �� *Player2Visibility+��5i      �� 5j      .R�5k      �� $
 Cards��6)   $
��Left=�68   $	 
Horizontal=�6S   5l      ��5n      �� 5o      .R�5p      �� $	��250��6%   $	��200��62   $��	100,0,0,0q�6>   ��6Q   �� ��6n   ��  �� " ��$ DataContext.CardSelected�.��5q   "   � .+�5r   &   �� $J��Dpack://application:,,,/ArcoMage;component/Images/CardBackground2.jpg��6,   $
��Fill=�6z   �� 5s   &   
�������$��Right=�6�   $	��Top=�6�   $��30��6�   $��30��6�   $
��Bold"�6�   $��22(�6�   ��6C   �� *
CostAmount+$ PropertyChanged=���6�   �� *	CostColor+$ PropertyChanged=��� 5t   &   $	 Vertical=�61   $��Center=�6H   $	��Top=�6e   $	��200��6}   $	��150��6�   .+�5u   *   �� $��20��64   $
��Bold"�6@   $��16(�6R   
��� ���$ Center=�6t   $��15q�6�   ��6�   �� *
CardName+$ PropertyChanged=�6�   �� 5v   *   $
��Fill=�6n   $	��100��6}   $	��140��6�   $��5,0,5,0q�6�   ��60   �� *Image+$ PropertyChanged=�6�   �� 5w   *   $
��Wrap=�6v   
��� ���$��15q�6�   ��64   �� *Description+$ PropertyChanged=�6�   5x   '   5y   #   5z      5{      5}      5      5�      � 5�   
   -   5        $ VictoryScreen��5�      y�6&   �� *VictoryScreenVisibility+.+�5�      �� $��80(�65   $
��Bold"�6C   $��Center=�6U   $��Center=�6r   ��6   �� *VictoryText+6r   5�      � 5�   
   -   5        $ MainMenu��5�      $y�	Collapsed=�6!   .+�5�      �� $��Hello��6   $��Center=�6%   $��Center=�6B   5�      5�      5�      