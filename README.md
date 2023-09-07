# Week 3 Assessment

## Setup
* Fork and Clone this repository
* Run `update-database` - let the instructors know if you run into any issues!

## Exercise (10 Points)
### Securing the Application (4 points)
* Use Secrets Managemnt to remove the database connection string from the application.
* So that we can see the full implmentation, include a screenshot below to show your `secrets.json` file
![SecretJSON](https://github.com/joe10111/Mod4Week3_Assessment/assets/41969516/0e8e330f-b8cd-466c-b3fe-01be5742605b)

### Maintaining Current-User (6 points)

This application includes some starter code so that we could maintain a current user.  Review the Login and Logout code in the Home Controller, along with the Login and Logout buttons in the Home/Index.cshtml file.  Building on this pre-existing structure:
* Create a cookie that holds a key for "currentUser" when a user logs in.
* Delete that cookie when a user logs out.
* Add the value of "current user" to all views

## Questions (10 Points)

1. Describe one strategy you have used to maintain state in a web application. (2 points)
	Since HTTP is a stateless protocol it is difficult to program states like logging in and logging out without having a secure way to keep track of states. This is where cookies come in! Cookies are strings of key-value pair data that are stored locally. We can use cookies to keep track of what user is logged in, how many times a user has visited a page or any programming logic that requires a state. 

2. How would you protect sensitive data that we need to store in our database - for example, passwords? (2 points)
	I would use SHA256 to hash encode my passwords before saving them to my database. SHA256 is a set of cryptographic hash methods. These methods allow us to encode our passwords by transforming them into a byte array and then into an encrypted string. This helps prevent hackers who could get a hold of database information from actually reading passwords as plain text. To then compare passwords in our application we can just encode the incoming password using SHA256 hashing methods. 

3. Describe 3 additional common security risks in web development. (Make sure you discuss what you know about the risk, and if you know how to minimize the risk) (6 points)
- Cross-site scripting or XSS is a security risk that involves the attacker injecting malicious scripts into web pages being viewed by another user. A successful attack compromises the victim's session, allowing the attacker to alter the web page's appearance or redirect the victim to an unwanted webpage.  
  - Minimize risk
   - Input validation and sanitization: Ensure that all user input is validated and sanitized before being processed or displayed back to users.
   - Use HTTP-only cookies: This attribute ensures that cookies cannot be accessed via JavaScript.
- SQL injection is an attack where malicious SQL code is inserted into a query from user input. This can lead to unauthorized viewing of data, corrupting, or even deleting data.
  - How to minimize the risk:
   - Use Prepared Statements: Using prepared statements ensures that user input is always treated as data and not executable code.
   - ORM (Object-Relational Mapping) tools can also reduce the risk as they often use parameterized queries by default.
- Cross-Site Request Forgery or CSRF is an attack that tricks a victim into submitting a malicious request. This is usually achieved by getting a victim to click a link or load an image that contains a malicious request to a site where the victim has admin or high-level access.
  - How to minimize the risk:
   - Require re-authentication or additional confirmation for sensitive actions


