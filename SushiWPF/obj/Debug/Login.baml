   M S B A M L   `   `   `  ����C  ?SushiWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SushiWPFSushiWPF  5   	       SushiWPF.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:SushiWPF     5   	     � Title$  Login��5   	   $��391.66��6   $��557.863��6'   ���	#FF232523 � 
ResizeMode$ NoResize=�6N   .��5	      � ���	#FFEEEEEE$��1,1,2,-1q�6"    � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� $��Ingreso��6   $
��Left=�6"   $��
187,10,0,0q�6=   $	��Top=�6Q   $	��150��6i   $��36(�6u   ���	#FFD8C6C6���	#DD111111$��Center=�6�   �� 5   
   -   5         ��Name$ txtUserName��5      $��40��6'   $��
41,95,49,0q�63    �� TextWrapping$
 Wrap=�6G   $	��Top=�6[   ���	#00FFF2F2$��20(�6�   �� 5   
   $��Correo eléctronico��6   $
��Left=�6-   $��	41,64,0,0q�6H   $	��Top=�6[   ���	#FF130D0D���	#DD131313$��16(�6�   �� 5   
   $��Contraseña��6   $
��Left=�6%   $��
41,146,0,0q�6@   $	��Top=�6T    J� RenderTransformOrigin$ -0.132,-0.347&�6l   ���	#DD272424���	#FFF3EEEE$��16(�6�   G� 5   
   -   5         G�Name$ txtPwd��5      $��41,166,49,0q�6&   $	��Top=�6;   $��38��6S   
������ $��20(�6x   6�   �� 5   
   -   5         ��Name$ btnIngresar��5      $��Ingresar��6&   $��	41,0,0,71q�69   
���   �$��41��6`   $��Bottom=�6l   $
��Left=�6�   $	��124��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Color$
 	#FF57BEE4��6#    � Offset$ 0Q�65   � 5      $
 	#FF636363��6#   $ 1Q�65   5      5      �� 5   
   -   5         ��Name$ 
lblMessage��5      $�� ��6$   $
��Left=�6/   $��
41,220,0,0q�6J   $	��Top=�6^   ���	#FFF5F1F1���	#DD111111$	��201��6�   �� 5   
   -   5        $ 
label_Copy��5      $'��!Fukusuke systems desktop version.��6$   $
��Left=�6P   $��10,0,-103,10q�6k   $	��642��6�   ���	#DD171717$��16(�6�   $��31��6�   $��Bottom=�6�   5      5      