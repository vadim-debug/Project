   M S B A M L   `   `   `  ????B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5          Project.Auto   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Project     5      -   5          N? Title$
  Auto??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??7* ?6   ?? 5      $??1* ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGridProject??5         AutoGenerateColumns .     
IsReadOnly . $??	0,10,0,56q?6W   $??2??6j      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Model??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   ?? *Model+6Z     5      $ Color??6%   $ * 6N    64   ?? *Color+6Z     5      $
 Year??6%   $ * 6L    63   ?? *Year+6X     5      $ STNumber??6%   $ * 6T    67   ?? *
StNumber+6`     5      $ DayPrice??6%   $ * 6T    67   ?? *
Dayprice+6`   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   	   CellTemplate	 5      ?? 5      BtnEdit??.R?5      ?? $	??sds??6=   -   5        $ ??Редактировать??5   %   6`   5      5       5$      ?? 5%   
   -   5        $??BtnAdd??5%   K   $	??5pxq?6   $??Добавить??6   $??2??61   $
??75px??6>   6p   ?? 5&   
   -   5        $??BtnDel??5&   e   $	??5pxq?6   $??Удалить??6   $??2??60   $
??75px??6=   $
??Left=?6J   6?   ?? 5'   
   -   5        $??BtnBackToMain??5'   d   $	??5pxq?6   $??
Назад??6   $??1??6.   $
??75px??6;   $??right=?6H   6?   5)      5*      