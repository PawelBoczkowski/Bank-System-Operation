   M S B A M L   `   `   `  ����B  >BankApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BankAppBankApp  5   	       BankApp.AccountWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:BankApp     5   	     � Title$  AccountWindow��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   �� -   5         ��Name$ AccountUserLabel��5
      $��Account User:��6*   $
��Left=�6B   $��	10,41,0,0q�6]   $	��Top=�6p   $��18(�6�   $	��127��6�   �� 5   
   -   5        $ AmountTextLabel��5      $��Amount of money:��6)   $
��Left=�6D   $��	10,10,0,0q�6_   $	��Top=�6r   $��18(�6�   �� 5   
   -   5        $ 
MoneyLabel��5      $�� ��6$   $
��Left=�6/   $��
171,10,0,0q�6J   $	��Top=�6^    J� RenderTransformOrigin$ 0.5,0.5&�6v   $��16(�6�   $��76��6�   �� 5   
   -   5        $ 	UserLabel��5      $�� ��6#   $
��Left=�6.   $��
137,41,0,0q�6I   $	��Top=�6]   $��18(�6u   $	��110��6�   �� 5   
   -   5         ��Name$ TransferListBox��5      $��505,26,40,170q�6+   6B   �� 5   
   -   5         ��Name$ LogoutButton��5      $��Logout��6'   $
��Left=�68   $��359,362,0,0q�6S   $	��Top=�6h   $��18(�6�   6�   �� 5   
   -   5        $ TransferToLabel��5      $��Transfer to:��6)   $
��Left=�6@   $��505,283,0,0q�6[   $	��Top=�6p   $��18(�6�   $	��255��6�   �� 5   
   -   5         ��Name$ AmountInput��5      $
��Left=�6'   $��512,322,0,0q�6B   $��Amount��6W    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��120��6�   $��16(�6�   �� 5   
   -	   5        $ 
SendButton��5      $��Send!��6%   $
��Left=�65   $��637,320,0,0q�6P   $	��Top=�6e   $��18(�6}   6�   5      5      