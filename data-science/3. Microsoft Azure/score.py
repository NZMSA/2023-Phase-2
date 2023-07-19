import json, os, joblib
import numpy as np

# Since the model works with label-encoded data, we can create a dictionary to get the actual class names
classes = {0: "setosa", 1: "versicolor", 2: "virginica"}

def init():
    # Loads the model
    global model
    model_path = "model.pkl"
    full_model_path = os.path.join(os.getenv("AZUREML_MODEL_DIR"), model_path)
    model = joblib.load(full_model_path)

def run(request):
    # Loads the input data, runs the model on it, and returns its predictions
    data = json.loads(request)
    data = np.array(data["data"])
    result = model.predict(data)
    return [classes.get(key) for key in result] 