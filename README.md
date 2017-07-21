# Eto-MVVMLight-Example


This is example how ETO [https://github.com/picoe/Eto] can use MVVMLight and data binding :

- This is the ViewModel which has a collection of users and this ViewModel [https://github.com/EbramSamy/Eto-MVVMLight-Example/blob/master/ETOApp/ViewModel/MainViewModel.cs]
exists in portable project which is shared between Windows and Mac Project: ViewModel

- This is the View [https://github.com/EbramSamy/Eto-MVVMLight-Example/blob/master/ETOApp/MainForm.xeto.cs] which has a ListViw Binding to users collection and this View exists also in the portable project which is shared between Windows and Mac Project: View
and that means the View and ViewModel are shared between Mac and Windows Projects.
