   M S B A M L   `   `   `  ????B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5          Project.Filter   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Project     5        N? Title$  Filter??5	      .??5      ? 
??????? ? RowDefinitions 5   
   ?? 5      $??1* ?6   6*   ?? 5      $??9* ?6   6*   ?? 5      $??1* ?6   6*   .+?5   
   ?  ? Orientation$ 
Horizontal=?6   $??Center=?6-   .+?5      ??  ?? Orientation$ 
Horizontal=?6   .+?5      ?? $2??,Введите название модели??6   $	??175??6;    ?? TextAlignment$ Right=?6G   6_   ?? 5      -   5        $??
TboxSearch??5   &   $	??225??6   6_   5      ?? 5      $ 
Horizontal=?6   .+?5      ?? $??Выберите год??6   $	??175??60   $ Right=?6<   6T   ?? 5      -   5        $??	ComboType??5   D   $	??225??6   ??6'   ?? *Year+6?   5      5      ?? 5   
   -   5        $??	LviewAuto??5       $??1??6    ?? View 5       ?? 5!      .P?5"      ??  ?? DisplayMemberBinding 6%   ??  ?? Path$ Model?.??6Q   Модель6Y   ?? 5#       6%   ?? $ Color?.??6Q   
Цвет6W   ?? 5$       6%   ?? $
 Year?.??6P   Год6U   ?? 5%       6%   ?? $ StNumber?.??6T   Рег Номер6_   ?? 5&       6%   ?? $ Dayprice?.??6T   Цена за день6b   ?? 5'      -   5        BtnEdit?? ?? Width$	 230??5'   7   	 ?? CellTemplate	 5(      ?? 5)      .R?5*   "   ?? $??BtnEdit1??6j   -   5        $ ??Редактировать??5*   )   $??Center=?6A   $	??230??6^   6?   5+      5-      50      53      ?? 54   
   -   5        $??BtnAdd??54   K   $	??5pxq?6   $??Добавить??6   $??2??61   $
??75px??6>   6p   ?? 55   
   -   5        $??BtnDel??55   e   $	??5pxq?6   $??Удалить??6   $??2??60   $
??75px??6=   $
??Left=?6J   6?   ?? 56   
   -   5        $??BtnBackToMain??56   d   $	??5pxq?6   $??
Назад??6   $??2??6.   $
??75px??6;   $??Right=?6H   6?   57      58      