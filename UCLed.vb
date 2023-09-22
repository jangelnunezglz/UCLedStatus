Imports System.Drawing
Imports System.Windows.Forms.Design
Imports System.Windows.Forms

Public Class UCLed

    Public Enum TextAlign
        MiddleLeft = 0
        MiddleRight = 1
    End Enum

    Public Enum Type
        Panic = 2
        Help = 4
        Support = 3
        Online = 1
    End Enum

    Public Enum Status
        Encendido = 1
        Apagado = 0
    End Enum

    Private _Status As Status = Status.Apagado
    Private _Tipo As Type = Type.Online
    Private _TextAlign As TextAlign = TextAlign.MiddleLeft
    Private _Text As String = "[Insert Text Here]"
    Private _X1 As Integer
    Private _X2 As Integer
    Private _IsBold As Boolean = False
    Public _IsRunning As Boolean = False
    Private Sub UCWeb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Interval = 400
        TxtAlign = _TextAlign
    End Sub
    Public Sub Start()
        Timer1.Enabled = True
    End Sub
    Public Sub Pause()
        Estado = Status.Apagado
        Timer1.Enabled = False
    End Sub
    Private _uflag As SByte
    Public Sub ShutDownEffect(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick

        If (IsRunning = True) Then
            If (_uflag = 1) Then
                pbxLED.Image = pbxOnline.Image
                _uflag = 0
            Else
                pbxLED.Image = pbxOFF.Image
                _uflag = 1
            End If
        End If
    End Sub
    Private Sub UCWeb_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize

        Me.ResizeCtrls(_X1, _X2)
    End Sub
    ''' <summary>Alignment of the text displayed</summary>'[Browsable(true)][DisplayName("TextAlign")][Description("The Alignment of the text displayed")]
    Public Property TxtAlign As TextAlign
        Get
            Return _TextAlign
        End Get
        Set(ByVal value As TextAlign)

            _TextAlign = value

            If (_TextAlign = TextAlign.MiddleLeft) Then
                ResizeCtrls(0, pbxLED.Width)
            End If

            If (_TextAlign = TextAlign.MiddleRight) Then
                'ResizeCtrls(lbDescription.Width, 0)
            End If
        End Set
    End Property
    '''<summary>The Text Displayed (Caption) of LED.</summary>'[Browsable(true)][DisplayName("TextDisplayed")][Description("The Text Displayed")]
    Public Property Texto As String
        Get
            Return _Text
        End Get
        Set(ByVal value As String)
            _Text = value
            ' lbDescription.Text = _Text.Trim()
            ' TxtAlign = _TextAlign ' //Resize Ctrls
        End Set
    End Property
    '''<summary>Determina si el proceso de apagado/encendido se encuentra ejecutando</summary>
    Public Property IsRunning As Boolean
        Get
            Return _IsRunning
        End Get
        Set(ByVal value As Boolean)
            _IsRunning = value
        End Set
    End Property
    '''<summary>Tipo de Encendido</summary> '[Browsable(true)][DisplayName("Type")][Description("Tipo de Encendido")]
    Public Property Tipo As Type
        Get
            Return _Tipo
        End Get
        Set(ByVal value As Type)
            _Tipo = value
            If (Estado = Status.Encendido) Then
                Select Case (_Tipo)
                    Case Type.Help : pbxLED.Image = pbxHelp.Image
                    Case Type.Online : pbxLED.Image = pbxOnline.Image
                    Case Type.Panic : pbxLED.Image = pbxPanic.Image
                    Case Type.Support : pbxLED.Image = pbxSupport.Image
                    Case Else
                        pbxLED.Image = pbxOnline.Image
                End Select
            End If
        End Set
    End Property

    '''<summary>Estado del LED (Prendido,Apagado) </summary>'[Browsable(true)][DisplayName("Status")][Description("Estado del LED (Prendido,Apagado)")]
    Public Property Estado As Status
        Get
            Return _Status
        End Get
        Set(ByVal value As Status)
            _Status = value
            If (_Status = Status.Apagado) Then
                pbxLED.Image = pbxOFF.Image
            Else 'Status.ON
                Select Case (_Tipo)
                    Case Type.Help : pbxLED.Image = pbxHelp.Image
                    Case Type.Online : pbxLED.Image = pbxOnline.Image
                    Case Type.Panic : pbxLED.Image = pbxPanic.Image
                    Case Type.Support : pbxLED.Image = pbxSupport.Image
                End Select
            End If
        End Set
    End Property
#Region "Methods"
    Private Sub ResizeCtrls()

        pbxLED.Location = New Point(_X1, 0)
        'lbDescription.Location = New Point(_X2, 1) ' //19, 1 
        ' Me.Size = New Size(pbxLED.Width + lbDescription.Width, pbxLED.Height) ' //MaxSize on Resize

    End Sub
    Private Sub ResizeCtrls(ByVal X1 As Integer, ByVal X2 As Integer)

        pbxLED.Location = New Point(X1, 0)
        ' lbDescription.Location = New Point(X2, 1) '//19, 1 
        _X1 = X1 : _X2 = X2
        ' Me.Size = New Size(pbxLED.Width + lbDescription.Width, pbxLED.Height) ' //MaxSize on Resize
    End Sub
#End Region

End Class

Public Class CDesigner
    Inherits ControlDesigner

    Protected Overrides Sub PreFilterEvents(ByVal events As System.Collections.IDictionary)

        '    ''' <summary></summary> 
        'Public Event ICheckAll(ByVal Bval As Boolean)

        ' ''' <summary></summary> 
        'Public Event ICellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)

        ' ''' <summary></summary> 
        'Public Event ICellCntentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)

        ' ''' <summary></summary> 
        'Public Event IConfirmed(ByVal Bval As Boolean)

        ' ''' <summary>Evento Disparado al seleccionar un Registro de forma automatica.</summary> 
        'Public Event ISelectedRow(ByVal Index As Integer)

        ' ''' <summary>Evento Disparado cada vez que se Elimina un Registro</summary> 
        'Public Event ISuccess()

        ' ''' <summary>Evento disparada cada vez que se carga el archivo tfm</summary> 
        'Public Event IUpdated()

        Try
            Dim ListEvents As List(Of DictionaryEntry) = events.Cast(Of DictionaryEntry).ToList
            Dim Events_Exceptions() As String = {"ICheckAll", "ICellDoubleClick", "ICellCntentClick", "IConfirmed", "ISelectedRow", "ISuccess", "IUpdated"}

            Dim EventName As String = ""

            'Seek Property Name in the List of Property Exceptions
            For Each EventFromList As DictionaryEntry In ListEvents
                EventName = EventFromList.Key.ToString.Trim

                If (Not Events_Exceptions.Any(Function(_PropertyName) EventName = _PropertyName)) Then
                    events.Remove(EventFromList.Key.ToString)
                End If
            Next
            '
            MyBase.PreFilterEvents(events)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PostFilterProperties", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'events.Clear()
    End Sub

    Protected Overrides Sub PostFilterProperties(ByVal properties As System.Collections.IDictionary)

        Try
            Dim ListProperties As List(Of DictionaryEntry) = properties.Cast(Of DictionaryEntry).ToList
            Dim Properties_Exceptions() As String = {"Name", "Size", "Location", "Tipo", "Estado", "Remark", "TxtAlign"}

            Dim ProperyName As String = ""

            'Seek Property Name in the List of Property Exceptions
            For Each PropertyFromList As DictionaryEntry In ListProperties
                ProperyName = PropertyFromList.Key.ToString.Trim

                If (Not Properties_Exceptions.Any(Function(_PropertyName) ProperyName =
                     _PropertyName OrElse ProperyName.StartsWith(_PropertyName & "_"))) Then
                    properties.Remove(PropertyFromList.Key.ToString)
                End If
            Next
            '
            MyBase.PostFilterProperties(properties) 'Save Changes
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PostFilterProperties", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class