   M S B A M L   `   `   `  ����   WPF_Test    WPF_Test.WPF_Test   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  WPF Test�� � SizeToContent$ WidthAndHeight=� � 
ResizeMode$ CanMinimize=�����  �� 
StartPoint$	 0,0&� �� EndPoint$	 1,1&�.���  � Color$ Black�� � Offset$	 0.0Q�� $
 Gray��$	 1.0Q�.���� $��10q����� $	 0,0&�$	 1,1&�.��� $
 Blue��$	 0.0Q�� $	 Red��$	 1.0Q�._��� -    ��Name$ 	mainStack��.+��� -    ��Name$ myList������ 	 �� 
TargetType"	 ��.�-   
 �� View
 �� .P���  �� Width$ 50��$��id�� �� DisplayMemberBinding �� *id+�� $ 50��$
��name�� �� CellTemplate �� .R���  � Cursor$
 Hand������ *name+�� $	 100��$��주소�� �� .R���  �� Orientation$ 
Horizontal=�.+��� $��5,0,5,0q����� *addr+A� $��15��$��15��$��5,0,5,0q���
�  
� GradientOrigin$ 0.3,0.3&� 
� Center$ 0.3,0.3&���� $ White��$	 0.1Q�� $	 0.9Q� �� *	itemColor+� $ DarkGray��$	 1.4Q��� $	 100��$��전화�� �� *mail+�� -   $ BookList������ "	 ��.�-   
 �� .P��� $ 70��$
��isbn�� �� *isbn+�� $	 130��$��bookname�� �� *
bookname+�� -    ��Name$ ColorBtn��$	��150��$��30��$��20q�.��Image Animation���� $ 0,0.5&�$ 1,0.5&�.��� $	 Red��$ 0Q�� $ Yellow��$	 0.5Q�� $ Green��$ 1Q� � Triggers :�  :� RoutedEvent$ Button.Loaded��[��� .����  �� TargetProperty$( "Background.GradientStops[1].Offset�.��W�  W� From$	 0.0X�	 W� To$	 1.0X� g� Duration$ 0:0:2D� g� AutoReverse .  g� RepeatBehavior$ Forever��