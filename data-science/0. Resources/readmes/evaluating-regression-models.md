# Evaluating Regression Models

Evaluating leads directly on from testing your model. A good accuracy on your test set is not enough to say that your model is useful! Your model could be overfitting on the test set, your dataset may contain lots of samples that are within a small range of values, and your regression model could simply be choosing a value within that range which would automatically yield a high accuracy without any "learning" taking place.

We would like you to evaluate your model using the following model evaluation techniques for your regression model/s:

1. Coefficient of determination ($R^{2}$)
    - Calculate and print this value, explaining what it means
2. RMSE
    - Calculate and print this value, explaining what it means
3. MAE
    - Calculate and print this value, explaining what it means

## 1. Coefficient of determination ($R^{2}$)

[$R^{2}$](https://en.wikipedia.org/wiki/Coefficient_of_determination) measures the strength and direction of the relationship between two variables (for our purposes, the model predictions (predicted y values) and the ground truth (actual y values)). A value of $-1$ or $1$ means that the variables have a strong negative or positive correlation, respectively, whereas a value of $0$ means that they have no correlation.

$R^{2}$ can be calculated as shown below:
```python
from sklearn.metrics import r2_score
r2 = r2_score(y_test, predictions)
```

## 2. Root mean squared error (RMSE)

RMSE tells us how far off our predictions are from ground truth (lower is better):
$$RMSE = \sqrt{\sum_{i=1}^{D}(y_{true}-y_{pred})^2}$$

RMSE can be calculated as shown below:
```python
from sklearn.metrics import mean_squared_error
rmse = mean_squared_error(y_true, y_pred, squared=False)
```

## 3. Mean absolute error (MAE)

MAE also tells how far off our predictions are from ground truth (lower is better), but we only take the absolute value of the errors without squaring or rooting them like with RMSE:
$$MAE = \sum_{i=1}^{D}|y_{true}-y_{pred}|$$

MAE can be calculated as shown below:
```python
from sklearn.metrics import mean_absolute_error
mae = mean_absolute_error(y_test, predictions)
```

---

### For Regression Models
Note for regression models, it is very similar with just an extra parameter for ```cross_val_score``` called scoring to state the metric being used. An example is given below:

```python
# Run the cross-validation on the model with -MSE
scores = cross_val_score(model, X, y, cv=cv, scoring='neg_mean_squared_error')

# Calculate the MSE mean and std
mse_scores = -scores
mean_mse = mse_scores.mean()
std_mse = mse_scores.std()

# Print MSE scores
print("Mean MSE:", mean_mse)
print("Standard Deviation of MSE:", std_mse)
```


[Scikit-learn model evaluation methods](https://scikit-learn.org/stable/modules/model_evaluation.html)