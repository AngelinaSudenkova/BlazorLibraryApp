   M S B A M L   `   `   `  ���� N  JAccuWeatherSolution, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AccuWeatherSolutionAccuWeatherSolution  $    AccuWeatherSolution.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:AccuWeatherSolution       � Title$  
MainWindow��$	��450��$	��800��.���  � ColumnDefinitions �� $
��177* ��� $
��500* ��� $
��124* �.+��� $
��Left=�$	��434��$��Center=�$	��230��#��� ��$��2���� $2��,Find the recent information
about your city��$
��Left=�$��
22,103,0,0q�$	��Top=�$	��186��$��2���� $��	City Info��$
��Left=�$��	22,62,0,0q�$	��Top=�$	��114��$��Segoe UI Black)�$��24(��� -    ��Name$ txtCity��$
��Left=�$��
22,169,0,0q� �� TextWrapping$
 Wrap=�$��Put the name of the city��$	��Top=�$	��208��$��28��$
��Thin"�$��2���� -    ��Name$ 	btnSearch��$��Find!��$
��Left=�$��
22,261,0,0q�$	��Top=�$��37��$��97�����	#FF0029B3$��20(�$��Segoe UI Black)�
����������� *LoadCitiesCommand+���� *Text+ �� ElementName$ txtCity���� -    ��Name$ lbData��$��119,0,430,-44q����	#FFDDE7FF$��2�� J� RenderTransformOrigin$ 0.5,0.5&�$	��253��$��Bottom=����� *Cities+ �� SelectedItem �� *SelectedCity+���� .R��� ���� *LocalizedName+z�V� .~��� �� 	 �� AngleY$	 0.666Q��� T� 
 T� Y$
 0.738Q��� $
��Left=�$��	22,18,0,0q�$	��Top=�$	��114��$��Segoe UI Black)�$��24(����� *SelectedCity.LocalizedName+�� -    ��Name$ 
chosenCity��$
��Left=�$��	74,18,0,0q�$	��Top=�$	��530��$��Segoe UI Black)�$��24(�$��1��$��2������ *SelectedCity.LocalizedName+�� -   $ neibghourButton��$��1��$��
Neighbours��$
��Left=�$��
84,160,0,0q�$	��Top=�$��27��$��99�����	#FF0029B3
�������$y�Visible=����� *LoadNeighboursCommand+���� *SelectedCity.Key+�� $��1��$��84,192,316,-192q����� *
Neighbours+���� .R��� ���� *LocalizedName+z�V� .~��� �� $	 0.666Q��� T� $
 0.738Q��� -   $ forecastButton��$��1��$��Forecast��$
��Left=�$��188,160,0,0q�$	��Top=�$��27��$��99�����	#FF0029B3
�������$y�Visible=����� *LoadForecastCommand+���� *SelectedCity.Key+�� $��1��$
��Left=�$��	198,0,0,0q�$
��Wrap=�$��Center=�$��89��$��52������ *ForecastView.headline+�� $��1��$
��Left=�$��198,248,0,0q�$
��Wrap=�$	��Top=�$��89��$��50������ *ForecastView.maxTemp+�� -   $ geopositionButton��$��1��$��Geoposition��$
��Left=�$��292,160,0,0q�$	��Top=�$��27��$��99�����	#FF0029B3
�������$y�Visible=����� *LoadGeopositionCommand+���� *SelectedCity.Key+�� $��1��$
��Left=�$��292,230,0,0q�$
��Wrap=�$	��Top=�$��99��$��28������ *GeopositionView.latitude+�� $��1��$
��Left=�$��292,280,0,0q�$
��Wrap=�$	��Top=�$��99��$��30������ *GeopositionView.longtite+�� -   $ historicalButton��$��1��$��
Historical��$
��Left=�$��400,160,0,0q�$	��Top=�$��27��$��99�����	#FF0029B3
�������$y�Visible=����� *LoadHistoricalCommand+���� *SelectedCity.Key+�� $��1��$��402,204,0,0q����� *Historicals+���� .R��� ���� *Facts+z�V� .~��� �� $	 0.666Q��� T� $
 0.738Q��� -	   $ 
linkButton��$��2��$��
Activities��$
��Left=�$��	6,160,0,0q�$	��Top=�$��27��$��99�����	#FF0029B3
�������$y�Visible=����� *LoadActivitiesCommand+���� *SelectedCity.Key+�� $��2��$��
8,199,19,5q����� *ActivitiesFun+���� .R��� ���� *ActivityInfo+z�V� .~��� �� $	 0.666Q��� T� $
 0.738Q��� $��Go to my library!��$
��Left=�$��
22,322,0,0q�$	��Top=�$��37��$��97�����	#FF0029B3$��10(�$��Segoe UI Black)�
����������� *OpenLibraryWindowCommand+���� *Text+$ txtCity��