   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   N JWebSocketServerTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WebSocketServerTestWebSocketServerTest 5   	   $   WebSocketServerTest.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   3local!clr-namespace:WebSocketServerTest     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      � $��14q�6    � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $
��Left=�6O   $��Center=�6j   .+�5      �� ���	#FFF5F5F5 �� Padding$ 4q�6,   ._�5      �� $
��Wrap=�6   $��16(�60    �� TextAlignment$ Center=�6>   $��Bottom=�6[   �� 5      -   5         ��Name$ protocol��5   -    �� SelectedIndex$ 0��6   @�5      ��5      wss��5      ��5      ws��5      5       �� 5       $�://127.0.0.1:��6    �� BaselineAlignment$ Center=�6+    �� 5!      -   5        	 ��Name$
	 port��5!      $��58��6(   $
��8998��66    �� 5"      $�	/repeater��6   $ Center=�6'   5#      5$      �� 5%      $
��10 0q�6   ���	#FFF5F5F5$ 4q�6:   ._�5&      �� $ Center=�6   $��Center=�69   �� 5'      $�请输入证书密码：��6   $ Center=�6&    �� 5(      $��666666��6   5)      5*      �� 5+      -   5        
 ��Name$
 Listen��5+      $	��5 0q�6%   $��监听��62   6?   �� 5,      -   5        $

 Stop��5,      $	��5 0q�6#   $��停止监听��61   6@   5-      �� 5.   
   $��0��6   $��1��6!   
�������$
��0 10q�6F   50      �� 52   
   -   5        $	 
receiveMsg��52   &   $��	10,10,0,0q�6   $��1��6:   $��1��6G    �� TextWrapping$
 Wrap=�6W    �� MinLines$ 10��6k    !  MaterialDesignOutlinedTextBox#��[  53      54      55      