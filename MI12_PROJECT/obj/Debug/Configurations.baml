   M S B A M L   `   `   `  ����M  ISkeletonBasics-WPF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Microsoft.Samples.Kinect.SkeletonBasics'Microsoft.Samples.Kinect.SkeletonBasics  5   	   <    6Microsoft.Samples.Kinect.SkeletonBasics.Configurations   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:Microsoft.Samples.Kinect.SkeletonBasics     5   	     � Title$  Fenêtre de configuration��5   	   $��514.764��6*   $��439.555��6;    � ShowActivated .  .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��213* �6   �� 5      $	��40* �6   �� 5      $
��170* �6   �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ activateSound��5      $��Activer le son��6*   $
��Left=�6C   $��	33,18,0,0q�6^   $	��Top=�6q    d� 	IsChecked$
 TrueY�6�   $��15��6�   $��91��6�   �� 5   
   -   5        $ activateColour��5      $��Activer la couleur��6+   $
��Left=�6H   $��
154,18,0,0q�6c   $	��Top=�6w    J� RenderTransformOrigin$ 0.533,2.344&�6�   $
 TrueY�6�   $��15��6�   $	��112��6�   $��3��6�   �� 5   
   -   5        $ activateGIF��5      $��Activer le GIF��6(   $
��Left=�6A   $��	39,19,0,0q�6\   $	��Top=�6o   $ 0.465,3.708&�6�   $
 TrueY�6�   $��15��6�   $��89��6�   $��2��6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.565Q�6&   T� 5      5      5      r� 5   
   -   5         r�Name$ mediaElementSound��5      $
��Left=�62   $��54��6M   $��
178,49,0,0q�6Y   $	��Top=�6m   $��70��6�    r� UnloadedBehavior$ Manual=�6�   	 r� Source$a	 [C:\Users\Jules\Documents\Visual Studio 2017\Projects\SkeletonBasics-WPF\Ressources\base.mp3?�6�   
 r� LoadedBehavior$
 Manual=�64   r� Stretch$
 None=�6L  $��2��6[  r� 5   
   -   5        $ mediaElementGIF��5      $
��Left=�60   $	��383��6K   $��
33,108,0,0q�6X   $	��Top=�6l   $	��383��6�   $ Manual=�6�   $j	 dC:\Users\Jules\Documents\Visual Studio 2017\Projects\SkeletonBasics-WPF\Ressources\runningmangif.mp4?�6�   $
 Manual=�6;  $
 None=�6S  $ 1.128,-0.565&�6b  $��3��6�  5      5       