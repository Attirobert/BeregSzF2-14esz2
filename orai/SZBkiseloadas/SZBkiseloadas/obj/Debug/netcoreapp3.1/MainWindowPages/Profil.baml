   M S B A M L   `   `   `  ����H  DSZBkiseloadas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SZBkiseloadas.MainWindowPagesSZBkiseloadas.MainWindowPages  5      9!clr-namespace:SZBkiseloadas.IconsSZBkiseloadas.Icons  6H   G(clr-namespace:SZBkiseloadas.UserControlsSZBkiseloadas.UserControls  6w   *    $SZBkiseloadas.MainWindowPages.Profil   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:SZBkiseloadas.MainWindowPages     5      2icon!clr-namespace:SZBkiseloadas.Icons     6H   AUserControls(clr-namespace:SZBkiseloadas.UserControls     6w   -   5          >�Name$  
profilMain��5   7   .��5	      �  � RowDefinitions 5
   
   �� 5      $��75 �6   �� 5      $��* �6   .+�5   
   �� $��1��6   
�������$	��Top=�65   .+�5      .   (SZBkiseloadas.UserControls.ProfilButton1  -   5          Name$ NevModositas��5   ?   .   (SZBkiseloadas.UserControls.ProfilButton1   PreviewMouseUp$! NevModositas_PreviewMouseUp��6U      Text$ Név módosítása��6)    � Cursor$
 Hand��6�     5      -   5        $ JelszoModositas��5   B   $$ JelszoModositas_PreviewMouseUp��6[   $ Jelszó módosítása��6)   $
 Hand��6�   .   (SZBkiseloadas.UserControls.ProfilButton2  5      -   5          Name$ FiokTorlese��5   =   .   (SZBkiseloadas.UserControls.ProfilButton2   PreviewMouseUp$  FiokTorlese_PreviewMouseUp��6R      Text$ Fiók törlése��6)   $
 Hand��6~     5      -   5        $ Kijelentkezés��5   >   $# Kijelentkezés_PreviewMouseUp��6U   $ Kijelentkezés��6)   $
 Hand��6�   5      � 5   
   -   5        $��header��5      $��0��6   
�������	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   
BlurRadius$
 15Q�6#      	Direction$	 -90Q�63      RenderingBias$ Quality=�6C      ShadowDepth$ 2Q�6[      Color$ 	#FFE8E8E8��6k    � ColumnDefinitions 5      �� 5      $��60 �6#   �� 5      $��* �6#   .+�5          SZBkiseloadas.Icons.Profil  $��0��6   $��23��6*      Fill
 �   �66   >� 5      $��1��6   $��Profil��6*   $��Segoe UI)�6;   $��Center=�6Q   $��25(�6l   $
��Bold"�6z   5      5      5       