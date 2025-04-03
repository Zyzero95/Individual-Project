import fetchAllAnimals from "./Actions/fetch";
import AnimalCard from "./Components/Animal Card/animalcard";

export default async function Home() {
  const data = await fetchAllAnimals();
  
  
  return (
    <main>
      {data?.map((animal) => <AnimalCard key={animal.id} data={animal}/>)}
    </main>
  );
}
