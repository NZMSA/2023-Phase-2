# Data Science Phase 2 Task 3

Welcome to Phase 2 Task 3! Congratulations for making it so far. Microsoft Azure is a cloud computing platform and service provided by Microsoft. For this task, you will learn how data scientists deploy machine learning models via the machine learning service in Microsoft's Azure.

# Prerequisites
1. An Azure account. If you don't have an Azure subscription, [create a free account](https://azure.microsoft.com/en-us/free/) before you begin.
2. Python or Anaconda
3. ```pip install azureml-core```

## Getting Started:
Firstly, we need to setup Azure to host our machine learning model:

1. Go to [Microsoft Azure portal page](https://azure.microsoft.com/en-us/get-started/azure-portal)

![azure.portal](./images/portal_page.png)

2. Create a resource and search for 'Azure Machine Learning' 

![azure.machine.learning](./images/ML_page.png)


3. Create the Machine Learning resource by filling in the details. Make sure you select the right region as **'Australia East'**. Other than that, you can name whatever they make sense to your project.


![azure.workplace_details](./images/workplace_details_page.png)

4. Click 'Review + Create'. After validation, it would take you to the deployment page. It would take around 1 minute for the whole deployment process. Wait till it show **'Your deployment is complete'**.

![azure.deployment_details](./images/deployment_ended.png)

5. Click 'Go to resources' and then click 'Launch studio'. This would take you the Machine Learning studio, which is a visual development environment for creating, testing, and deploying machine learning models without extensive coding. It offers pre-built modules, a drag-and-drop interface, experiment tracking, collaboration features, and integration with other Azure services.

![azure.studio_details](./images/ML_studio.png)


## Model Training:

Before we deploy our model we would first need to train one. In this example, I trained a XGBoost model on the well known iris dataset. 

For task 3, you are allowed to choose one dataset to train in the dataset list. If you are stuck you can access the [Official Microsoft Documentation](https://docs.microsoft.com/en-us/azure/machine-learning/how-to-deploy-and-where?tabs=azcli) which will guide you to deploying any type of machine learning model.

Feel free to use this sample code and practice how to train a model then deploy it :)

```python
# Example model training on the iris dataset 
# Load libraries for creating a xgboost model of the iris dataset 
from sklearn import datasets
from sklearn.model_selection import train_test_split
from xgboost import XGBClassifier

# Load the data 
iris = datasets.load_iris() 
X = iris.data                
y = iris.target      

# Split data into test and train 
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size = 0.2, random_state = 42)

# Create XGBoost classifier and save model 
xgbClf = XGBClassifier(use_label_encoder = False)
xgbClf.fit(X_train, y_train)
xgbClf.save_model("model.json")
```

## Datasets list:
* [Best Songs on Spotify for every year (2000-2023)](https://www.kaggle.com/datasets/conorvaneden/best-songs-on-spotify-for-every-year-2000-2023)
* [AI Global Index](https://www.kaggle.com/datasets/katerynameleshenko/ai-index)
* [COVID -19 Coronavirus Pandemic Dataset](https://www.kaggle.com/datasets/whenamancodes/covid-19-coronavirus-pandemic-dataset)

## Submission Requirements:
