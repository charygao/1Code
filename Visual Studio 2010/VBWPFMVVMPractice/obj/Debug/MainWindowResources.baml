   M S B A M L   `   `   `  ����L  HVBWPFMVVMPractice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:VBWPFMVVMPracticeVBWPFMVVMPractice  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   CellTextStyle  �� 
TargetType �� Property �� Value �� Triggers �� Binding �� Path �� Value  StatusTextStyle �� BasedOn  MoveNumberStyle ^� 
Conditions	 �� Binding
 �� Value O� 	GlowColor O� GlowSize �� DataType"    VBWPFMVVMPractice.PlayerMove   VBWPFMVVMPractice.Cell
 � Tag �� RelativeSource �� AncestorType �� 
TargetType �� Triggers P� Property P� Value �� 
TargetName/   )VBWPFMVVMPractice.IntToBoolValueConverter  	converter�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      )localclr-namespace:VBWPFMVVMPractice  5      %6
  &	        &	 �    7   &	     (�� �    58      *,  +)7   7  (�� �    5>      *, +)'�� j    &	 �	    �� 5      "  ��6"   .�5   
   ��  � ��$
 32pt(�6%   �� 5   
    � ��$
 Bold"�6'   �� 5   
    � ��$ Center=�6.   �� 5	   
    � ��$ Center=�60    5
   
   �� 5       6   �� $ 
PlayerName� x6>   .a�5      ��  � ��
 �  ��6/   5      �� 5       6   �� $ 
PlayerName� o6>   .a�5      ��  � ��
 � � �6/   5      5      �� 5      8   "  ��6M   .�5   
   ��  � ��$ Normal"�6'   �� 5   
    � ��
 �����6'   5      �� 5      "  ��6$   .�5   
   ��  � ��$
 12pt(�6%   �� 5   
    � ��$ Italic$�6&   �� 5   
    � ��$ Bottom=�6.   �� 5   
    � ��$ Right=�60    5   
   ^� 5       5       �� 5!      	 6    �� *
PlayerName+
 x6?   �� 5"      	 6    �� *IsPartOfWin+
 true6@   .0�5$      ��  �@J�BitmapEffect 5%      O� 5&      $	 Red��60   $ 10Q�6@   5(      5)      ^� 5+       5,      �� 5-      	 6    �� *
PlayerName+
 o6?   �� 5.      	 6    �� *IsPartOfWin+
 true6@   .0�50      ��  �@J�BitmapEffect 51      O� 52      $ Green��60   $ 10Q�6B   54      55      57      �� 58      "   6   .R�59   
   � .+�5:      �� 8��  ��6   �� $ 
PlayerName�69   �� 5;      8�� ��6   �� $ 
MoveNumber�69   5<      5=      �� 5>      "  6   .R�5?   
   �� ��6   �� *Move+ 6*   �� *
CellNumber+��6E   ��  �� *FindAncestor+$ ItemsControlL�$ DataContext.MoveCommand���5A      �� *
CellNumber+5B      �� 5D      "  ��6   .�5E   
   ��  � ��$ Stretch=�60   �� 5F   
    � ��$ Stretch=�6.   �� 5G   
    � ��$ 8q�6$   �� 5H   
    � ��
 �����6'   �� 5I   
    � ��$ 3q�6#   �� 5J   
    � �� 5K      �� 5L      " ��6"   .R�5M      � .+�5N      �� $
��rect��6$   #��z��60   #��z��6T   �� 5O      #��z��6+   5P       5Q      P� 5R       �@J�IsMouseOver . . �5S      �� $
 rect��6%    �@J�BitmapEffect 5T   "   O� 5U   &   $ Yellow��6<   $ 10Q�6O   5W      5X      5Z      5\       5]   
   P� 5^       � �� 6)   Z� . �5_      ��  �@�ToolTip$ click to move here��6,   5`      P� 5a       �@J�	IsFocused . . �5b      ��  �@�ToolTip$$ click or spacebar to move here��6,   5c      5e        5g      6$   5h      