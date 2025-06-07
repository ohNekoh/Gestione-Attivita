Imports System.Net.Mime.MediaTypeNames

Public Class Form1
    Dim nomiAttivita, descrizioniAttivita As New List(Of String)
    Dim listaStati As New List(Of Boolean)
    Dim listaDate As New List(Of Date)
    Dim nomeAttivita, descAttivita As String
    Dim dataStringa As String
    Dim dataData As Date

    Const MaxCapienza = 10


    Dim firstTime As Boolean = True



    Private Sub Aggiungi()
        Dim isDone As Boolean = False
        Do Until isDone
            nomeAttivita = InputBox("Inserisci il nome dell'attività", "Nekoh")
            If nomeAttivita = "" Then
                MsgBox("Il nome non può essere vuoto!", MsgBoxStyle.Exclamation, "Nekoh")
                Continue Do
            End If
            nomiAttivita.Add(nomeAttivita)
            descAttivita = InputBox("Inserisci la descrizione dell'attività", "Nekoh")
            If descAttivita = "" Then
                MsgBox("La descrizone non può essere vuota!", MsgBoxStyle.Exclamation, "Nekoh")
                Continue Do
            End If
            descrizioniAttivita.Add(descAttivita)
            dataStringa = InputBox("Inserisci la data dell'attività", "Nekoh")
            If dataStringa = "" Then
                MsgBox("La data non può essere vuota!", MsgBoxStyle.Exclamation, "Nekoh")
                Continue Do
            End If
            dataData = CDate(dataStringa)
            listaDate.Add(dataData)
            listaStati.Add(False)
            If MsgBox("Vuoi inserire un'altra attività?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Nekoh") = vbNo Then
                isDone = True
            End If
            Continue Do
        Loop
        firstTime = False
    End Sub
    Private Sub Azzera()
        nomiAttivita.Clear()
        descrizioniAttivita.Clear()
        listaDate.Clear()
        listaStati.Clear()
        lstStato.Items.Clear()
        lstData.Items.Clear()
        lstDescrizione.Items.Clear()
        lstNome.Items.Clear()
    End Sub

    Private Sub Visualizza()
        lstNome.Items.Clear()
        lstDescrizione.Items.Clear()
        lstData.Items.Clear()
        lstStato.Items.Clear()
        For Each nome In nomiAttivita
            lstNome.Items.Add(nome)
        Next
        For Each descrizione In descrizioniAttivita
            lstDescrizione.Items.Add(descrizione)
        Next
        For Each dataa In listaDate
            lstData.Items.Add(dataa)
        Next
        For Each stato In listaStati
            If Not stato Then
                lstStato.Items.Add("Non completato")
            Else
                lstStato.Items.Add("Completato")
            End If
        Next
    End Sub
    Private Sub btnInserisci_Click(sender As Object, e As EventArgs) Handles btnInserisci.Click
        If Not firstTime Then
            If MsgBox("Questa opzione eliminerà tutte le attività esistenti! Vuoi procedere?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Nekoh") = vbNo Then
                Return
            End If
        End If
        Call Azzera()
        Call Aggiungi()
    End Sub

    Private Sub btnVisualizza_Click(sender As Object, e As EventArgs) Handles btnVisualizza.Click
        Call Visualizza()
    End Sub

    Private Sub btnAggiungi_Click(sender As Object, e As EventArgs) Handles btnAggiungi.Click
        Call Aggiungi()
    End Sub

    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        If MsgBox("Questa opzione eliminerà tutte le attività esistenti! Vuoi procedere?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Nekoh") = vbNo Then
            Return
        End If
        Call Azzera()
    End Sub

    Private Sub btnSostituisci_Click(sender As Object, e As EventArgs) Handles btnSostituisci.Click
        Dim posizioneDaSostituire As Double = (Val(InputBox("Inserisci la posizione dell'attività da sostituire", "Nekoh"))) - 1
        If posizioneDaSostituire < 0 Or posizioneDaSostituire >= nomiAttivita.Count Then
            MsgBox("Posizione non valida!", MsgBoxStyle.Exclamation, "Nekoh")
            Return
        End If
        Dim nuovoNome As String = InputBox("Inserisci il nuovo nome dell'attività", "Nekoh")
        If nuovoNome = "" Then
            MsgBox("Il nome non può essere vuoto!", MsgBoxStyle.Exclamation, "Nekoh")
            Return
        End If
        Dim nuovaDescrizione As String = InputBox("Inserisci la nuova descrizione dell'attività", "Nekoh")
        If nuovaDescrizione = "" Then
            MsgBox("La descrizione non può essere vuota!", MsgBoxStyle.Exclamation, "Nekoh")
            Return
        End If
        nomiAttivita(posizioneDaSostituire) = nuovoNome
        descrizioniAttivita(posizioneDaSostituire) = nuovaDescrizione
        MsgBox("Attività sostituita con successo!", MsgBoxStyle.Information, "Nekoh")
    End Sub

    Private Sub btnCerca_Click(sender As Object, e As EventArgs) Handles btnCerca.Click
        Dim descrizioneDaCercare As String = InputBox("Inserisci la descrizione da cercare", "Nekoh")
        If descrizioneDaCercare = "" Then
            MsgBox("La descrizione non può essere vuota!", MsgBoxStyle.Exclamation, "Nekoh")
            Return
        End If
        Dim found As Boolean = False
        For i As Integer = 0 To descrizioniAttivita.Count - 1
            If descrizioniAttivita(i).Contains(descrizioneDaCercare) Then
                MsgBox("Attività trovata: " & nomiAttivita(i) & vbCrLf & "Descrizione: " & descrizioniAttivita(i), MsgBoxStyle.Information, "Nekoh")
                found = True
                Exit For
            End If
        Next
        If Not found Then
            MsgBox("Nessuna attività trovata con la descrizione specificata.", MsgBoxStyle.Information, "Nekoh")
        End If

    End Sub

    Private Sub btnCercaData_Click(sender As Object, e As EventArgs) Handles btnCercaData.Click
        Dim cercaData As String = CDate(InputBox("Inserisci la data da cercare", "Nekoh"))
        Dim found As Boolean = False
        For i As Integer = 0 To listaDate.Count - 1
            If listaDate(i) = cercaData Then
                MsgBox("Attività trovata: " & nomiAttivita(i) & Environment.NewLine & " Descrizione: " & descrizioniAttivita(i), MsgBoxStyle.Information, "Nekoh")
                found = True
            End If
        Next
        If Not found Then
            MsgBox("Nessuna attività trovata!", MsgBoxStyle.Exclamation, "Nekoh")
        End If
    End Sub

    Private Sub btnContaData_Click(sender As Object, e As EventArgs) Handles btnContaData.Click
        Dim numeroFound As Double = 0
        Dim cercaData As String = CDate(InputBox("Inserisci la data da cercare", "Nekoh"))
        For i As Integer = 0 To listaDate.Count - 1
            If listaDate(i) = cercaData Then
                numeroFound += 1
            End If
        Next
        MsgBox("Numero di attività trovate per la data selezionata: " & CStr(numeroFound), MsgBoxStyle.Information, "Nekoh")
    End Sub

    Private Sub btnImpostaStato_Click(sender As Object, e As EventArgs) Handles btnImpostaStato.Click
        Dim posizioneDaSostituire As Double = Val(InputBox("Inserisci la posizione dell'attività da assegnare:", "Nekoh")) - 1
        If posizioneDaSostituire < 0 Or posizioneDaSostituire >= nomiAttivita.Count Then
            MsgBox("Posizione non valida!", MsgBoxStyle.Exclamation, "Nekoh")
            Return
        End If
        If (Not listaStati(posizioneDaSostituire)) Then
            If MsgBox("Questa attività è contrassegnata come non completata, vuoi completarla?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Nekoh") = vbYes Then
                listaStati(posizioneDaSostituire) = True
                MsgBox("L'attività " & nomiAttivita(posizioneDaSostituire) & " è stata contrassegnata come completata!", MsgBoxStyle.Information, "Nekoh")
            Else
                MsgBox("Operazione interrotta", MsgBoxStyle.Critical, "Nekoh")
            End If
        Else
            If MsgBox("Questa attività è contrassegnata come completata, vuoi segnarla come non completata?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Nekoh") = vbYes Then
                listaStati(posizioneDaSostituire) = False
                MsgBox("L'attività " & nomiAttivita(posizioneDaSostituire) & " è stata contrassegnata come non completata!", MsgBoxStyle.Information, "Nekoh")
            Else
                MsgBox("Operazione interrotta", MsgBoxStyle.Critical, "Nekoh")
            End If
        End If
    End Sub

    Private Sub btnEsci_Click(sender As Object, e As EventArgs) Handles btnEsci.Click
        If MsgBox("Vuoi uscire dal programma?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Nekoh") = vbYes Then
            End
        End If
        Return
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Benvenuto nel programma di gestione attività!", MsgBoxStyle.Information, "Made by Nekoh")
    End Sub
End Class
