Public Structure Ticket3
    ' each ticket in the database will need a 


    'Contains a User, CoffeeShop and Review structure.

    Public Structure User
        ' also the structure that the user will take when creating the user object. 
        Private _username As String

        ' creates a username variable without creating multiple instances of the username property of 
        'the new or given username 
        Public Property Username() As String
            Get
                Return _username
            End Get
            Set(ByVal value As String)
                _username = value
            End Set
        End Property

        Private _email As String
        Public Property Email() As String
            Get
                Return _email
            End Get
            Set(ByVal value As String)
                _email = value
            End Set
        End Property

        '' this id will be used to id a user by number relating to a hashmap.
        Private _id As Integer
        Public Property Id() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property

        ' returns the username and e-mail in this format. this format append the e-mail to the username format.
        Public Overrides Function ToString() As String
            Return Username + "(" + Email + ")"
        End Function

    End Structure

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~SEPERATE STRUCTURE~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    '' a light weight class. Does and can this relate to a DBO ?  
    '' Ticket needs to have Tech ID , Problem Ticket Number, Description, Datecalledin, location , and severity 
    Public Structure Ticket

        Private _locationOfProblem As String
        Public Property Location() As String
            Get
                Return _locationOfProblem
            End Get
            Set(ByVal value As String)
                _locationOfProblem = value
            End Set

        End Property
        ' this isn't implemented yet , but will be recorded as the person logging the ticket. 
        Private _user As String
        Public Property User() As String
            Get
                Return _user
            End Get
            Set(ByVal value As String)
                _user = value
            End Set
        End Property

        ' the ticket number 
        Private _ticketId As Integer
        Public Property Id() As Integer
            Get
                Return _ticketId
            End Get
            Set(ByVal value As Integer)
                _ticketId = value
            End Set
        End Property

        '' the serverity of the problem
        Private _severity As Integer
        Public Property Severity() As Integer
            Get
                Return _severity
            End Get
            Set(ByVal value As Integer)
                _severity = value
            End Set
        End Property

        ' don't think i need this 
        'Public Overrides Function ToString() As String
        '    Return Name + ", " + Address
        'End Function

    End Structure
    '' the structure a review needs to have. think of structures as light weight classes. 
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Public Structure Review

        Private _rating As Integer
        Public Property Rating() As Integer
            Get
                Return _rating
            End Get
            Set(ByVal value As Integer)
                _rating = value
            End Set
        End Property


        Private _reviewText As String
        Public Property ReviewText() As String
            Get
                Return _reviewText
            End Get
            Set(ByVal value As String)
                _reviewText = value
            End Set
        End Property

        Private _userID As Integer
        Public Property UserID() As Integer
            Get
                Return _userID
            End Get
            Set(ByVal value As Integer)
                _userID = value
            End Set
        End Property
        ''' <summary>
        ''' 'different kind of user 
        ''' </summary>
        ''' <remarks></remarks>
        Private _user As User
        Public Property TheUser() As User
            Get
                Return _user
            End Get
            Set(ByVal value As User)
                _user = value
            End Set
        End Property

        Private _userName As String
        Public Property UserName() As String
            Get
                Return _userName
            End Get
            Set(ByVal value As String)
                _userName = value
            End Set
        End Property


        Private _coffeeShopID As Integer
        Public Property ShopID() As Integer
            Get
                Return _coffeeShopID
            End Get
            Set(ByVal value As Integer)
                _coffeeShopID = value
            End Set
        End Property
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!COFFEESHOP!!!!!!!!!!!!!!!!!!!!!!!!!!~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        ' THE COFFEE SHOP HERE IS WHAT IS NEEDED TO CREATE A NEW COFFEE SHOP DATE. 
     

        'Private _coffeeShop As CoffeeShop
        'Public Property TheCoffeeShop() As CoffeeShop
        '    Get
        '        Return _coffeeShop
        '    End Get
        '    Set(ByVal value As CoffeeShop)
        '        _coffeeShop = value
        '    End Set
        'End Property

        Private _date As Date
        Public Property ReviewDate() As Date
            Get
                Return _date
            End Get
            Set(ByVal value As Date)
                _date = value
            End Set
        End Property

        'Used for the display in the GUI

        ' also check to see how this is formatted when sent to the DB.
        Public Overrides Function ToString() As String
            Return String.Format("{0} stars - {1} - {2} - {3} ", Rating, ReviewText, UserName, ReviewDate.ToShortDateString)
        End Function

    End Structure
End Structure