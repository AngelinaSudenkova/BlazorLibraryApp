   M S B A M L   `   `   `  ���� N  JAccuWeatherSolution, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AccuWeatherSolutionAccuWeatherSolution  '    !AccuWeatherSolution.LibraryWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:AccuWeatherSolution       � Title$  LibraryWindow��$	��450��$	��800��.��� .+��� -    ��Name$ lbData��$��
545,0,4,-1q����	#FFDDE7FF J� RenderTransformOrigin$ 0.5,0.5&�$	��381��$��Bottom=����� *Books+ �� SelectedItem �� *SelectedBook+���� .R��� ���� *Title+z�V� .~��� ��  �� AngleY$ 0.666Q��� T�  T� Y$ 0.738Q��� $��Add book��$
��Left=�$��
19,217,0,0q�$	��Top=�$��37��$��97�����	#FF0029B3$��10(�$��Segoe UI Black)�
����������� *CreateBookCommand+���� *Text+ �� ElementName$ txtCity���� $��Delete book��$
��Left=�$��436,217,0,0q�$	��Top=�$��37��$��97�����	#FF0029B3$��10(�$��Segoe UI Black)�
����������� *DeleteBookCommand+���� *Text+$ txtCity���� $��Update book��$
��Left=�$��161,217,0,0q�$	��Top=�$��37��$��97�����	#FF0029B3$��10(�$��Segoe UI Black)�
����������� *UpdateBookCommand+���� *Text+$ txtCity���� $��	Find book��$
��Left=�$��301,217,0,0q�$	��Top=�$��37��$��97�����	#FF0029B3$��10(�$��Segoe UI Black)�
����������� *GetBookCommand+���� *Text+$ txtCity���� $��Load ny library��$
��Left=�$��153,276,0,0q�$	��Top=�$��37��$	��224�����	#FF0029B3$��10(�$��Segoe UI Black)�
����������� *LoadBooksCommand+�� -    ��Name$ idTxt��$
��Left=�$��	63,51,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��175��$ 0.229,-0.889&�$��24������ *
NewBook.Id+	 �� Mode$	 TwoWay=��� -   $ titleTxt��$
��Left=�$��	63,80,0,0q�$
 Wrap=�$	��Top=�$	��175��$ 0.229,-0.889&�$��40������ *NewBook.Title+$	 TwoWay=��� -   $ 	AuthorTxt��$
��Left=�$��
63,125,0,0q�$
 Wrap=�$	��Top=�$	��175��$ 0.229,-0.889&�$��40������ *NewBook.Author+$	 TwoWay=��� -   $ descriptionTxt��$
��Left=�$��
294,51,0,0q�$
 Wrap=�$	��Top=�$	��215��$ 0.229,-0.889&�$	��114������ *NewBook.Description+$	 TwoWay=��� $	��id:��$
��Left=�$��4,45,0,0q�$	��Top=��� $��Author:��$
��Left=�$��	3,119,0,0q�$	��Top=��� $��Title:��$
��Left=�$��3,74,0,0q�$	��Top=��� $��Desc:��$
��Left=�$��
246,51,0,0q�$	��Top=��� $
��Left=�$��
96,342,0,0q�$
��Wrap=�$	��Top=�$��82��$	��388����`� 
 �� StringFormat$7
 1Title: {0}, Author: {1}, Description: {2}, Id:{3}��.1���  �� Path$ SelectedBook.Title��� $ SelectedBook.Author��� $ SelectedBook.Description��� $ SelectedBook.Id��� $
��Left=�$��	63,10,0,0q�$
��Wrap=�$	��Top=�$	��446��$��36������ *ResponseText+