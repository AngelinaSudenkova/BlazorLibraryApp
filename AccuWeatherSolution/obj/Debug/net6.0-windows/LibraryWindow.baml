   M S B A M L   `   `   `  ����N  JAccuWeatherSolution, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AccuWeatherSolutionAccuWeatherSolution  5   	   '    !AccuWeatherSolution.LibraryWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:AccuWeatherSolution     5   	     � Title$  LibraryWindow��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   �� -   5         ��Name$ lbData��5
      $��
545,0,4,-1q�6"   ���	#FFDDE7FF J� RenderTransformOrigin$ 0.5,0.5&�6M   $	��381��6m   $��Bottom=�6z   ��6�   �� *Books+ �� SelectedItem 6�   �� *SelectedBook+��5      �� 5      .R�5      �� ��6    �� *Title+5      z�5      V� 5      .~�5      �� �� 5       �� AngleY$ 0.666Q�6$   �� 5      T� 5       T� Y$ 0.738Q�6)   5      5      �� 5   
   $��Add book��6   $
��Left=�6�   $��
19,217,0,0q�6�   $	��Top=�6�   $��37��6�   $��97��6�   ���	#FF0029B3$��10(�6�   $��Segoe UI Black)�6  
���������6$   �� *CreateBookCommand+��6J   �� *Text+ �� ElementName$ txtCity��6   �� 5   
   $��Delete book��6   $
��Left=�6�   $��436,217,0,0q�6�   $	��Top=�6�   $��37��6�   $��97��6�   ���	#FF0029B3$��10(�6�   $��Segoe UI Black)�6  
���������6'   �� *DeleteBookCommand+��6M   �� *Text+$ txtCity��6$  �� 5   
   $��Update book��6   $
��Left=�6�   $��161,217,0,0q�6�   $	��Top=�6�   $��37��6�   $��97��6�   ���	#FF0029B3$��10(�6�   $��Segoe UI Black)�6  
���������6'   �� *UpdateBookCommand+��6M   �� *Text+$ txtCity��6$  �� 5   
   $��	Find book��6   $
��Left=�6   $��301,217,0,0q�6�   $	��Top=�6�   $��37��6�   $��97��6�   ���	#FF0029B3$��10(�6�   $��Segoe UI Black)�6  
���������6%   �� *GetBookCommand+��6H   �� *Text+$ txtCity��6  �� 5   
   $��Load ny library��6   $
��Left=�6P   $��153,276,0,0q�6k   $	��Top=�6�   $��37��6�   $	��224��6�   ���	#FF0029B3$��10(�6�   $��Segoe UI Black)�6�   
���������6+   �� *LoadBooksCommand+6�   �� 5   
   -   5         ��Name$ idTxt��5      $
��Left=�6!   $��	63,51,0,0q�6<    �� TextWrapping$
 Wrap=�6O   $	��Top=�6�   $	��175��6�   $ 0.229,-0.889&�6�   $��24��6�   ��6d   �� *
NewBook.Id+	 �� Mode$	 TwoWay=�6�   �� 5   
   -   5        $ titleTxt��5      $
��Left=�6$   $��	63,80,0,0q�6?   $
 Wrap=�6R   $	��Top=�6�   $	��175��6�   $ 0.229,-0.889&�6�   $��40��6�   ��6f   �� *NewBook.Title+$	 TwoWay=�6�   �� 5    
   -   5        $ 	AuthorTxt��5       $
��Left=�6%   $��
63,125,0,0q�6@   $
 Wrap=�6T   $	��Top=�6�   $	��175��6�   $ 0.229,-0.889&�6�   $��40��6�   ��6h   �� *NewBook.Author+$	 TwoWay=�6�   �� 5!   
   -   5        $ descriptionTxt��5!      $
��Left=�6*   $��
294,51,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6�   $	��215��6�   $ 0.229,-0.889&�6�   $	��114��6�   ��6m   �� *NewBook.Description+$	 TwoWay=�6�   �� 5"   
   $	��id:��6   $
��Left=�6   $��4,45,0,0q�69   $	��Top=�6K   �� 5#   
   $��Author:��6   $
��Left=�6"   $��	3,119,0,0q�6=   $	��Top=�6P   �� 5$   
   $��Title:��6   $
��Left=�6!   $��3,74,0,0q�6<   $	��Top=�6N   �� 5%   
   $��Desc:��6   $
��Left=�6    $��
246,51,0,0q�6;   $	��Top=�6O   �� 5&   
   $
��Left=�6   $��
96,342,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��82��6o   $	��388��6{   ��5'      `� 5(      
 �� StringFormat$7
 1Title: {0}, Author: {1}, Description: {2}, Id:{3}��6   .1�5)      ��  �� Path$ SelectedBook.Title�6   �� 5*      $ SelectedBook.Author�6   �� 5+      $ SelectedBook.Description�6   �� 5,      $ SelectedBook.Id�6   5-      5/      �� 50   
   $
��Left=�6   $��	63,10,0,0q�6/   $
��Wrap=�6B   $	��Top=�6t   $	��446��6�   $��36��6�   ��6V   �� *ResponseText+6�   52      53      