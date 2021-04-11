Feature: SignInWithGoogleAccount
AS a User on Giftrete website (www.giftrete.com)
I want to sign up with my google account.
So that I can use my google details to sign in

@SignInWithGoogleAccount
Scenario: Sign in with an existing google account
	Given  that I am a user- on Giftrete website ( www.giftrete.com)
	When I click sign in
	And I click google icon button
	And I enter email or phone
	And I click next
	And I enter password
	And I tick show password box(Optional)
	And I click on next
	Then I must sign in to giftrete dashbord successfully