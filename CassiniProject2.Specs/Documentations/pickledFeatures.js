jsonPWrapper ({
  "Features": [
    {
      "RelativeFolder": "Login.feature",
      "Feature": {
        "Name": "Login",
        "Description": "In order to use the Ieso Therapy site\r\nAs an existing user\r\nI want to be able to Login and Logout",
        "FeatureElements": [
          {
            "Name": "Login as an existing user with correct login details",
            "Slug": "login-as-an-existing-user-with-correct-login-details",
            "Description": "",
            "Steps": [
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I enter correct details and login",
                "TableArgument": {
                  "HeaderRow": [
                    "email",
                    "password"
                  ],
                  "DataRows": [
                    [
                      "ieso.digital+joyprivacypatient4@gmail.com",
                      "Logarp44"
                    ]
                  ]
                },
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should be navigated to the user account page",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false,
              "WasProvided": false
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "email",
                    "password",
                    "message"
                  ],
                  "DataRows": [
                    [
                      "pkjufhfhuwhkmfwhh.gmail.com",
                      "",
                      "Wrong email or password",
                      {
                        "WasExecuted": false,
                        "WasSuccessful": false,
                        "WasProvided": true
                      }
                    ],
                    [
                      "ieso.digital+joytestcassini@gmail.com",
                      "Logarp44",
                      "Wrong email or password",
                      {
                        "WasExecuted": false,
                        "WasSuccessful": false,
                        "WasProvided": true
                      }
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "Login with incorrect login details",
            "Slug": "login-with-incorrect-login-details",
            "Description": "",
            "Steps": [
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I enter incorrect login details \"<email>\" \"<password>\"",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see an error \"<message>\" displayed on the page",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false,
              "WasProvided": false
            }
          },
          {
            "Name": "Logout as an existing user",
            "Slug": "logout-as-an-existing-user",
            "Description": "",
            "Steps": [
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I successfully login with my details",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should be able to logout",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false,
              "WasProvided": false
            }
          },
          {
            "Name": "View my profile as an existing user",
            "Slug": "view-my-profile-as-an-existing-user",
            "Description": "",
            "Steps": [
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I successfully login with my details",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should be able to view my profile",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false,
              "WasProvided": false
            }
          }
        ],
        "Background": {
          "Name": "User is on the Registration",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I am on the Login page",
              "StepComments": [],
              "AfterLastStepComments": []
            }
          ],
          "Tags": [],
          "Result": {
            "WasExecuted": false,
            "WasSuccessful": false,
            "WasProvided": false
          }
        },
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false,
          "WasProvided": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false,
        "WasProvided": false
      }
    },
    {
      "RelativeFolder": "RegisterUser.feature",
      "Feature": {
        "Name": "RegisterUser",
        "Description": "In order to use the Ieso Therapy site\r\nAs a new user\r\nI want to be able to Sign up",
        "FeatureElements": [
          {
            "Name": "Register with correct email and password format",
            "Slug": "register-with-correct-email-and-password-format",
            "Description": "",
            "Steps": [
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I enter correct email format and password 'Logarp44' and signup",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should be navigated to the Welcome page",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false,
              "WasProvided": false
            }
          },
          {
            "Name": "Register with correct email and password format without accepting privacy policy",
            "Slug": "register-with-correct-email-and-password-format-without-accepting-privacy-policy",
            "Description": "",
            "Steps": [
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I enter correct email format and password \"Logarp44\" without accepting privacy policy",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see \"You must agree to the terms and conditions\" displayed on the page",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false,
              "WasProvided": false
            }
          },
          {
            "Name": "Register with an existing user details",
            "Slug": "register-with-an-existing-user-details",
            "Description": "",
            "Steps": [
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I enter existing user details \"ieso.digital+joyprivacypatient@gmail.com\" \"Logarp44\" and signup",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the message \"Invalid sign up\" displayed on the page",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false,
              "WasProvided": false
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "email",
                    "password",
                    "message"
                  ],
                  "DataRows": [
                    [
                      "ffhfhuwhfwhfwh.gmail.com",
                      "",
                      "(password) is too short",
                      {
                        "WasExecuted": false,
                        "WasSuccessful": false,
                        "WasProvided": true
                      }
                    ],
                    [
                      "",
                      "",
                      "(password) is too short",
                      {
                        "WasExecuted": false,
                        "WasSuccessful": false,
                        "WasProvided": true
                      }
                    ],
                    [
                      "",
                      "Logarp44",
                      "error in email",
                      {
                        "WasExecuted": false,
                        "WasSuccessful": false,
                        "WasProvided": true
                      }
                    ],
                    [
                      "ieso.digital+joytestcassini@gmail.com",
                      "",
                      "(password) is too short",
                      {
                        "WasExecuted": false,
                        "WasSuccessful": false,
                        "WasProvided": true
                      }
                    ],
                    [
                      "ieso.digital+joytestcassini@gmail.com",
                      "f123",
                      "object",
                      {
                        "WasExecuted": false,
                        "WasSuccessful": false,
                        "WasProvided": true
                      }
                    ],
                    [
                      "ebfnsbfabjsfbasjf.com@gmail",
                      "dghn",
                      "error in email",
                      {
                        "WasExecuted": false,
                        "WasSuccessful": false,
                        "WasProvided": true
                      }
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "Register with incorrect email and password format",
            "Slug": "register-with-incorrect-email-and-password-format",
            "Description": "",
            "Steps": [
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I enter incorrect \"<email>\" and incorrect \"<password>\" and signup",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see error \"<message>\" displayed on the page",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false,
              "WasProvided": false
            }
          }
        ],
        "Background": {
          "Name": "User is on the Registration",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I am on the Registration page",
              "StepComments": [],
              "AfterLastStepComments": []
            }
          ],
          "Tags": [],
          "Result": {
            "WasExecuted": false,
            "WasSuccessful": false,
            "WasProvided": false
          }
        },
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false,
          "WasProvided": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false,
        "WasProvided": false
      }
    }
  ],
  "Summary": {
    "Tags": [],
    "Folders": [
      {
        "Folder": "Login.feature",
        "Total": 4,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 4
      },
      {
        "Folder": "RegisterUser.feature",
        "Total": 4,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 4
      }
    ],
    "NotTestedFolders": [
      {
        "Folder": "Login.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "RegisterUser.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "Scenarios": {
      "Total": 8,
      "Passing": 0,
      "Failing": 0,
      "Inconclusive": 8
    },
    "Features": {
      "Total": 2,
      "Passing": 0,
      "Failing": 0,
      "Inconclusive": 2
    }
  },
  "Configuration": {
    "SutName": "Cassini Project Test",
    "SutVersion": "1.0",
    "GeneratedOn": "20 February 2020 09:39:58"
  }
});