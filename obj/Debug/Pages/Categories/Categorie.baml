   M S B A M L   `   `   `  ����P  LWPFModernVerticalMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:WPFModernVerticalMenu.Pages.Categories&WPFModernVerticalMenu.Pages.Categories  5      6    0WPFModernVerticalMenu.Pages.Categories.Categorie   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:WPFModernVerticalMenu.Pages.Categories     5        N� Title$  	Categorie��5	      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgCategorie��5         AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6D    J� RenderTransformOrigin$ 0.5,0.5&�6T   $��	0,36,0,36q�6t   $��16(�6�      CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width$	 200 6%      Header$ IdCategorie��61   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6G   �� *idCategorie+  5      $	 200 6%   $
 Code��61   	 6?   �� *CodeCategorie+  5      $	 200 6%   $ Libelle��61   	 6B   �� *LibelleCategorie+4  .System.Windows.Controls.DataGridTemplateColumn  5      
   HeaderTemplate
 5      �� 5      .R�5      �� $��Action��6(   5         CellTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   $��5q�6B   .+�5   "   ��  ��Name$ btnModifierCategorie��6)   -   5        $��Modifier��5   G   $��0,0,10,0q�6n   
��� ���
�������
��� ���6�   �� 5   "   $ btnSupprimer��6)   -   5        $��	Supprimer��5   ?   
���  ��
�������
���  ��6�   5      5      5      5!      �� 5"   
   -   5        $ 
BtnAjouter��5"      $��Ajouter��6%   $
��Left=�67   $��
707,-2,0,0q�6R   $	��Top=�6f   $��20(�6~   $��33��6�   $��93��6�   
��� � �
�������
��� � �6�   5$      5&      