   M S B A M L   `   `   `  ����L  HVBWPFMVVMPractice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:VBWPFMVVMPracticeVBWPFMVVMPractice  5      "    VBWPFMVVMPractice.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      1localclr-namespace:VBWPFMVVMPractice     5        � Title$  TicTacToe game��5       � 	Resources 5       �� Source�� 5   
   $ MainWindowResources.xaml?�6   %    .��5
      ]� 
���   �.+�5   
   o� $	��Top=�6   .@�5      m� $
��Game��6   .@�5      m� $��	_3x3 Game��6   /   )VBWPFMVVMPractice.ChangeDimensionBehavior   	Dimension$ 3��6.    m� 	IsChecked 5      �� *	Dimension+   	converter �� 	Converter# [   �� ConverterParameter$ 3�� �� Mode$ OneWay=�m� 5      $��	_4x4 Game��6   $ 4��6.    5      �� *	Dimension+# [  $ 4��$ OneWay=�m� 5      $��	_5x5 Game��6   $ 5��6.    5      �� *	Dimension+# [  $ 5��$ OneWay=�m� 5      $��_Exit��6   (   "VBWPFMVVMPractice.ShutdownBehavior   ForceShutdown$ falseX�6*   5      5      �� 5   
     StatusTextStyle#��[ 6   $��Bottom=�6=   It's your move, �� 5      ��6   �� *CurrentPlayerName+6>   �� 5   
   ��6   �� *Cells+��5      �� 5      .R�5      A� 5       ��5"      �� 5#      	 �� 
TargetType"	 ��6"   .R�5$      � .+�5%      �� 
��� � �
 �� RadiusX$
 20��61    �� RadiusY$ 20��6>   �� 5&      $��20q�6)   5'      5(      5*      5+      5,      