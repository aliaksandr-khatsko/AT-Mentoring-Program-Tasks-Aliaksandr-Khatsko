Feature: AddToCart
	In order to place orders from Cart
	As a user
	I want have a possiblity to add items to Cart

Background:
	Given I logged in as a user
	And Cart is empty
	And Watch list is empty
 
@ItemPage
Scenario: Add an item to Cart
	And I navigate to the Item page for the FirstItem
	When I press Add To Cart button on the Item page
	Then the Cart page should be opened
	And the FirstItem should be added to cart


@ItemPage
Scenario: Add the second item to Cart
	And I navigate to the Item page for the FirstItem
	And I press Add To Cart button on the Item page
	And I navigate to the Item page for the SecondItem
	When I press Add To Cart button on the Item page
	Then the Cart page should be opened
	And the SecondItem should be added to cart
	

@WatchPage
Scenario: Add an item to Cart from 'Watch' page
	And an item added to watch list
	And I navigate to the the Watch page
	When I press Add To Cart button on the Item page
	Then the Cart page should be opened
	And the FirstItem should be added to cart

@ItemPage
Scenario: Navigate to Cart via 'Added to Cart' link
	And I navigate to the Item page for the FirstItem
	And I press Add To Cart button on the Item page
	And I navigate to the Item page for the FirstItem
	When I press Added To Cart link on the Item page
	Then the Cart page should be opened

@ItemPage
Scenario Outline: Add an item to Cart using quantity
	And I navigate to the Item page for the FirstItem
	And I set up the quantity <qty>
	When I press Add To Cart button on the Item page
	Then the Cart page should be opened
	And the item should be added to cart with correct quantity <qty>

Examples: 
| qty |
| 2   |
| 11  |

