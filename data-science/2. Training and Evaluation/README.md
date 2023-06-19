# Part 2 - Training and Evaluation

Machine Learning (ML), as the name suggests, is all about teaching a machine *how* to think and not *what* to think. While this topic and others related to big data have been around for decades, it is becoming more popular than ever because the barrier to entry has become lower. This is mainly because everyday computers are now becoming increasingly more capable of the heavy lifting required to do all the maths behind ML. It's good because ML algorithms are now accessible to more people that can solve more problems in the real world and not just in well-funded computer science departments. It’s bad because a lower barrier to entry means that there is a greater risk that more people will not know how the tools they are using actually function and can come to incorrect conclusions about the results that these tools generate.

As such, it is vital that you don't just know what to do, but also know why you’re doing it. Imagine if you were a mechanic and you asked a coworker to give you a tool (e.g. a wrench) to fix a problem that you (and supposedly the worker too) are familiar with - your coworker hands you a Phillips screwdriver, and then they hand you a flathead screwdriver, and then a hammer. At best, this shows a complete lack of understanding of the problem at hand. At worst, it makes solving the problem impossible or even worse, sets you up for a hazardous and harmful operation that could cost both you and your coworker.

<div align="center">
  <div style="float:left;margin-right:10px;">
  <img src="https://github.com/NZMSA/2023-Phase-2/assets/67076071/fa342869-aef3-43d8-9714-d1a2d8b5cc80"
  width=550
  height=auto
  ><br>
    <p style="font-size:1.5vw;">"Man is a tool-using animal. Without tools, he is nothing. With tools, he is all." — Thomas Carlyle</p>
  </div>
</div>

In a similar way, if you are a data scientist and you can't explain how you're training your models but you claim that you've validated the results your models are producing, and interpret your results as if they were right, then the work you do may lead to negative consequences for you, your employer, and the people who will use the results of your models. This is why the need to make sure that you use the right tools is paramount. So now that we've hammered our point (no pun intended), we'll guide you on what to do when training ML models and just as (if not, more) importantly, how to evaluate them.

There are many categories of machine learning problems (a specific problem's category can be determined by its target variable and data modelling goals), but we are only going to focus on two for this part: classification and regression. As a refresher, the main difference between classification and regression is that classification is about predicting a discrete variable while regression is about predicting a continuous variable. For both types of problems, we can train and test an ML model but oftentimes, models can seem to achieve good results during testing but when they get deployed in the real world, they fail in an utterly miserable way. One of the main reasons that this happens is due to overfitting (i.e. the model is great at predicting using data it has already seen but terrible at predicting using new data). To overcome this, we can use cross-validation beforehand to get a sense of how a model will perform in the real world. This involves splitting the dataset into a certain number of groups (also called folds) and then using each fold of the data to test a model that has been trained on all the other folds.

## Tasks

To help you train and evaluate your models, we have split up training and evaluation into the following tasks to complete. We have provided a `part2-submission.ipynb` notebook to use as a template for these tasks. You may adapt this notebook as you wish and/or create your own.

  1. [Load and split preprocessed data](#1-Load-and-split-preprocessed-data)
  2. [Choose an algorithm](#2-Choose-an-algorithm)
  3. [Train and test a model](#3-Train-and-test-a-model)
  4. [Evaluate the model](#4-Evaluate-the-model)
  5. [Summary](#5-Summary)

### 1. Load and split preprocessed data

- Write a brief description of each dataset (what features are present within it + their data types, what your target is)
    - Since notebooks are meant to be easily readable, a person who has no clue what the datasets are might have trouble understanding your notebook.
- Split your preprocessed datasets into a training set and a test set
    - The ultimate goal is to use a subset of the data to train a model that can be used to predict unseen data. This can be done by splitting our dataset into two sets: a training set and a test set. The test set is kept untouched during training so that it can be used to evaluate our trained models and get an estimate of how they would perform with new data in the real world.

### 2. Choose an algorithm

- Choose an appropriate algorithm for your chosen classification dataset
    - We suggest that you choose an algorithm you learned in the Microsoft Learn modules from Phase 1, such as random forest or logistic regression
- Choose an appropriate algorithm for your chosen regression dataset
    - We suggest that you choose an algorithm you learned in the Microsoft Learn modules from Phase 1, such as linear regression
- In your own words inside your notebook, write a few sentences on how each of your chosen algorithms works
    - We suggest that you research and understand the algorithms that you are using (since they all work differently from each other) so that you can better understand what's involved when training and evaluating a model, and start to gain an intuition for what models would be the best for certain problems and not others.

### 3. Train and test a model

- Train a model using your chosen classification algorithm on your chosen classification dataset
- Train a model using your chosen regression algorithm on your chosen regression dataset
- Test your trained classification model using the accuracy metric
- Test your trained regression model using the mean squared error (MSE)

### 4. Evaluate the model

- Evaluate your trained classification model
    - Please refer to [Evaluating Classification Models](./evaluating-classification-models.md)
- Evaluate your trained regression model
    - Please refer to [Evaluating Regression Models](./evaluating-regression-models.md)

### 5. Summary

- Write a brief summary that describes:
    - The steps you've taken to train and evaluate your models.
    - The results you've found while training and evaluating your models.
    - Any interesting things you found during training and evaluation that you'd like to mention in order to showcase the extent of your understanding. We suggest doing things like:
        - Find the class that your classification model struggles with the most and explain why you think that is and how it can be fixed (this may involve doing some EDA on your model predictions).
        - Look up the coefficients of your regression model and briefly mention what these coefficients mean.

### Bonus

If you would like to extend yourself (and potentially attain a mark greater than 100% for this part!), then here are some additional tasks you can do on top of the above.
- Tune your chosen models in at least one way e.g. find the best value of a single hyperparameter, find the best train-test split
  - Please refer to [Tuning Models](./tuning-models.md)
  - If you decide to do this bonus task, quantitatively described the improvement after tuning using an evaluation metric in your notebook
- Perform tasks 2-4 on one to two other algorithms for each dataset, compare their performances against each other, and then choose the model with the best performance for task 5. There are various other algorithms that you could create other models from that were covered in the Microsoft Learn modules, including:
    - Decision tree
    - K-nearest neighbours
    - Lasso regression
    - Gradient boosting
    - Neural network (refer to this Microsoft Learn module for more information: [Train and evaluate deep learning models](https://learn.microsoft.com/en-us/training/modules/train-evaluate-deep-learn-models))

Feel free to refer to the [Supervised learning section](https://scikit-learn.org/stable/user_guide.html#user-guide) of the Scikit-learn user guide for more information on how to implement the algorithms above and their parameters. If you decide to do this bonus task, show the performance of each model in your notebook.

## Submission

To complete this part, please include the following items in your repository:

1. A Jupyter notebook (.ipynb) containing your training and evaluation work for your chosen classification dataset
2. A Jupyter notebook A Jupyter notebook (.ipynb) containing your training and evaluation work for your chosen regression dataset
3. A summary (a Markdown cell in each notebook you create, .txt, .pdf, or in another readable format)
    - Think of this as a TL;DR for your notebooks.
    - While there is no word limit, we may penalise summaries that are more than 500 words long (we have a lot of submissions to get through, so the more concise you can be, the better!), or do not provide a sufficient overview of everything you have done. A key skill to master in data science is your ability to communicate technical concepts in a clear way.

## Marking Criteria

1. Task Completion

For each task, we will be making sure that you have met the criteria below.

- Load and split preprocessed data
    - You have loaded in and split your datasets from Part 1 appropriately
        - We suggest using a random state of 101 with a 70-30 train-test split (assuming you don't do any tuning as part of the bonus tasks)
- Choose an algorithm
    - You have chosen an appropriate algorithm for each dataset
- Train and test a model
    - You have trained and tested your models appropriately
    - You have printed a simple metric for each model's predictions and/or draw a graph for linear regression
- Evaluate the model
    - You have used evaluation metrics for each model
    - You have used cross-validation
    - You have graphically evaluated each model using confusion matrices, ROC curves, or otherwise
- Summary
    - You have summarised what you have found during training and evaluation
    - You have concisely described the training and evaluation steps you have taken for each of your chosen datasets
    - You have included possible next steps that you could take to improve your models

2. Presentation
    - Your notebook/s and the code within them must be well-commented so that someone looking at your notebook/s for the first time can easily understand and follow along with what you did
        - Note that "well-commented" means that you have provided easily understandable explanations for what the results of your code mean or what you have inferred from them
        - We may penalise notebooks that only contain code and nothing else
    - Your comments clearly explain the training and evaluation steps you have taken and justify why you took those steps

## Tips

This part relies heavily on the Microsoft Learn modules from Weeks 3 and 4 of Phase 1! Below are some resources that you might find helpful:
  - [Scikit-Learn Model Cheatsheet](https://s3.amazonaws.com/assets.datacamp.com/blog_assets/Scikit_Learn_Cheat_Sheet_Python.pdf))
  - Testing a model:
    ```python
    # Classification
    from sklearn.metrics import accuracy_score
    accuracy = accuracy_score(y_test, predictions)
    ```
    ```python
    # Regression
    from sklearn.metrics import mean_squared_error
    mse = mean_squared_error(y_test, predictions)
    ```
  - Getting regression coefficients:
    ```python
    # Get regression model coefficients
    pd.DataFrame(model.coef_, X.columns, columns = ['Coefficient'])[:-1]
    ```
  -  [No Free Lunch Theorem (NFLT)](https://robertmarks.org/Classes/ENGR5358/Papers/NFL_4_Dummies.pdf): When it comes to data modelling, a beginner's question is always "What is the best ML algorithm to learn?" To this, a beginner must learn the NFLT which states that there is no one algorithm that can achieve the best results in all problems. So the best approach is to try different ML algorithms, tune them, and compare them against each other for our specific problem. We can have an intuition on what type of model can be used by understanding what type of problem we are dealing with.

More often than not, data scientists need to go back to their training and evaluation steps after realising they need to train or evaluate their data better or in a different way. So don't be afraid to revisit this part after you think you've completed it, and write about any changes you made to your training and evaluation steps in your summary!
