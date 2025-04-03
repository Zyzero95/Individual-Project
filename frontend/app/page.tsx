import fetchAllAnimals from "./Actions/fetch";

export default async function Home() {
  const data = await fetchAllAnimals();
  
  
  return (
    <main>

    </main>
  );
}
