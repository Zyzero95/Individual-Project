import { AnimalInterface } from "../Interfaces/animalinterface";

const url = "http://localhost:5088/animals"

// Uses default url for fetching all data from API.
export default async function fetchAllAnimals(): Promise<AnimalInterface[] | null> {
  try {
    const response = await fetch(url);
    if(!response.ok){
        throw new Error(`Response status: ${response.status}`);
    }

    const json = await response.json();
    
    return json;
    
  }
  catch(error: unknown) {
    if(error instanceof Error){
        console.error(error.message);
    }
  }
  return null;
}

// Uses data Id to fetch the corresponding data.
export async function fetchAnimal(id: number): Promise<AnimalInterface | null> {
    try {
        const response = await fetch(`${url}/${id}`);
        if(!response.ok){
            throw new Error(`Response status: ${response.status}`);
        }

        const json = await response.json();
        return json;

    } catch (error: unknown) {
        if(error instanceof Error){
            console.error(error.message);
        }
    }
    return null;
}